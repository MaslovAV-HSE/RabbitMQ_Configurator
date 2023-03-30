using Docker.DotNet;
using Docker.DotNet.Models;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Бокеры_сообщений.Modules
{
    // Module that transfers rabbitmq files from this app to servers and containers
    public static class RabbitMQFileTransferer
    {
        // Function to transfer rabbitmq.conf file to container
        public async static Task<string> ContainerTransferConfigurationFile(string containerName, string content)
        {
            Stream stdin = new MemoryStream();
            Stream stdout = new MemoryStream();
            Stream stderr = new MemoryStream();

            var client = new DockerClientConfiguration().CreateClient();

            var containers = await client.Containers.ListContainersAsync(new ContainersListParameters { All = true });
            string containerId = containers.FirstOrDefault(c => c.Names.Contains($"/{containerName}"))?.ID;

            if (containerId == null)
            {
                return $"Невозможно найти контейнер по заданному имени {containerName}";
            }

            var checkExecParams = new ContainerExecCreateParameters()
            {
                AttachStderr = true,
                AttachStdout = true,
                Cmd = new List<string> { "/bin/sh", "-c", "cd /etc/rabbitmq" },
            };

            var checkExec = await client.Exec.ExecCreateContainerAsync(containerName, checkExecParams);

            var checkStream = await client.Exec.StartAndAttachContainerExecAsync(checkExec.ID, false);

            await checkStream.CopyOutputToAsync(stdin, stdout, stderr, CancellationToken.None);

            if (stderr.Length > 0)
            {
                return $"Брокер RabbitMQ не найден в контейнере {containerName}";
            }

            stdin.SetLength(0);
            stderr.SetLength(0);
            stdout.SetLength(0);

            var configExecParams = new ContainerExecCreateParameters()
            {
                AttachStderr = true,
                AttachStdout = true,
                Cmd = new List<string> { "/bin/sh", "-c", "printenv RABBITMQ_CONFIG_FILE" },
            };

            var configExec = await client.Exec.ExecCreateContainerAsync(containerName, configExecParams);

            var configStream = await client.Exec.StartAndAttachContainerExecAsync(configExec.ID, false);

            await configStream.CopyOutputToAsync(stdin, stdout, stderr, CancellationToken.None);

            string config_file = "";

            if (stdout.Length > 0)
            {
                stdout.Position = 0;

                using (StreamReader sr = new StreamReader(stdout))
                {
                    config_file = sr.ReadToEnd();
                }
            }
            else
            {
                config_file = "/etc/rabbitmq/rabbitmq.conf";
            }

            stdin.SetLength(0);
            stderr.SetLength(0);
            stdout.SetLength(0);

            var transferExecParams = new ContainerExecCreateParameters()
            {
                AttachStderr = true,
                AttachStdout = true,
                Cmd = new List<string> { "/bin/sh", "-c", $"echo \'{content}\' > {config_file}" },
            };

            var transferExec = await client.Exec.ExecCreateContainerAsync(containerName, transferExecParams);

            var transferStream = await client.Exec.StartAndAttachContainerExecAsync(transferExec.ID, false);

            await transferStream.CopyOutputToAsync(stdin, stdout, stderr, CancellationToken.None);

            stdin.Dispose();
            stdout.Dispose();
            stderr.Dispose();

            return $"Конфигурационный файл в контейнере: {containerName} создан по пути {config_file}";
        }

        // Function to transfer rabbitmq.conf file to server
        public static string ServerTransferConfigurationFile(string host, string user, string password, string content)
        {
            var sshClient = new SshClient(host, user, password);

            try
            {
                sshClient.Connect();
            }
            catch
            {
                return $"Невозможно подключиться к серверу {host} по введённым данным";
            }

            var statusCmd = sshClient.CreateCommand("systemctl status rabbitmq-server");
            var status = statusCmd.Execute();

            if (statusCmd.Error != "")
            {
                return $"Утилита не смогла найти сервер RabbitMQ на узле {host}. Возможно вы не установили сервер RabbitMQ.";
            }

            var fileNameCmd = sshClient.CreateCommand("printenv RABBITMQ_CONFIG_FILE");
            var config_file = fileNameCmd.Execute();

            if (config_file == "")
            {
                config_file = "/etc/rabbitmq/rabbitmq.conf";
            }

            ShellStream shellStream = sshClient.CreateShellStream("shell", 200, 24, 1920, 1080, 4096);

            shellStream.WriteLine($"sudo -i");
            shellStream.Flush();

            shellStream.WriteLine(password);
            shellStream.Flush();

            Thread.Sleep(1000);

            shellStream.WriteLine($"echo \'{content}\' > {config_file}");
            shellStream.Flush();

            Thread.Sleep(1000);

            shellStream.WriteLine("systemctl stop rabbitmq-server");
            shellStream.Flush();

            Thread.Sleep(1000);

            shellStream.WriteLine("systemctl start rabbitmq-server");
            shellStream.Flush();

            Thread.Sleep(1000);

            shellStream.Dispose();

            sshClient.Disconnect();

            return $"Настройка сервера RabbitMQ на сервере {host} завершена";
        }

        // Function to transfer python file of reciever example to container
        public async static Task<string> ContainerTransferExampleReciever(string containerName, int port = 5672, string path = "/etc/rabbitmq")
        {
            string python_script = "import pika, sys, os\n\n" +
                    "def main():\n    " +
                    "connection = pika.BlockingConnection(pika.ConnectionParameters(host=\"localhost\", port=" + port.ToString() +
                    "))\n    " +
                    "channel = connection.channel()\n\n    " +
                    "channel.queue_declare(queue=\"hello\")\n\n    " +
                    "def callback(ch, method, properties, body):\n        " +
                    "print(\" [x] Received %r\" % body)\n\n    " +
                    "channel.basic_consume(queue=\"hello\", on_message_callback=callback, auto_ack=True)\n\n    " +
                    "print(\" [*] Waiting for messages. To exit press CTRL+C\")\n    " +
                    "channel.start_consuming()\n\n" +
                    "if __name__ == \"__main__\":\n    " +
                    "try:\n        " +
                    "main()\n    " +
                    "except KeyboardInterrupt:\n        " +
                    "print(\"Interrupted\")\n        " +
                    "try:\n            " +
                    "sys.exit(0)\n        " +
                    "except SystemExit:\n            " +
                    "os._exit(0)";

            Stream stdin = new MemoryStream();
            Stream stdout = new MemoryStream();
            Stream stderr = new MemoryStream();

            var client = new DockerClientConfiguration().CreateClient();

            var containers = await client.Containers.ListContainersAsync(new ContainersListParameters { All = true });
            string containerId = containers.FirstOrDefault(c => c.Names.Contains($"/{containerName}"))?.ID;

            if (containerId == null)
            {
                return $"Невозможно найти контейнер по заданному имени {containerName}";
            }

            var transferExecParams = new ContainerExecCreateParameters()
            {
                AttachStderr = true,
                AttachStdout = true,
                Cmd = new List<string> { "/bin/sh", "-c", $"echo \'{python_script}\' > {path}/reciever.py" },
            };

            var transferExec = await client.Exec.ExecCreateContainerAsync(containerName, transferExecParams);

            var transferStream = await client.Exec.StartAndAttachContainerExecAsync(transferExec.ID, false);

            await transferStream.CopyOutputToAsync(stdin, stdout, stderr, CancellationToken.None);

            stdin.Dispose();
            stdout.Dispose();
            stderr.Dispose();

            return $"Для запуска получателя в контейнере {containerName} в командной строке контейнера введите: python {path}/reciever.py";
        }

        // Function to transfer python file of sender example to container
        public async static Task<string> ContainerTransferExampleSender(string containerName, int port = 5672, string path = "/etc/rabbitmq")
        {
            string python_script = "import pika\n\n" +
                    "connection = pika.BlockingConnection(pika.ConnectionParameters(host=\"localhost\", port=" + port.ToString() +
                    "))\n\n" +
                    "channel = connection.channel()\n\n" +
                    "channel.queue_declare(queue=\"hello\")\n\n" +
                    "channel.basic_publish(exchange=\"\", routing_key=\"hello\", body=\"Example message\")\n" +
                    "print(\" [x] Sent \'Example message\'\")\n" +
                    "connection.close()";

            Stream stdin = new MemoryStream();
            Stream stdout = new MemoryStream();
            Stream stderr = new MemoryStream();

            var client = new DockerClientConfiguration().CreateClient();

            var containers = await client.Containers.ListContainersAsync(new ContainersListParameters { All = true });
            string containerId = containers.FirstOrDefault(c => c.Names.Contains($"/{containerName}"))?.ID;

            if (containerId == null)
            {
                return $"Невозможно найти контейнер по заданному имени {containerName}";
            }

            var transferExecParams = new ContainerExecCreateParameters()
            {
                AttachStderr = true,
                AttachStdout = true,
                Cmd = new List<string> { "/bin/sh", "-c", $"echo \'{python_script}\' > {path}/sender.py" },
            };

            var transferExec = await client.Exec.ExecCreateContainerAsync(containerName, transferExecParams);

            var transferStream = await client.Exec.StartAndAttachContainerExecAsync(transferExec.ID, false);

            await transferStream.CopyOutputToAsync(stdin, stdout, stderr, CancellationToken.None);

            stdin.Dispose();
            stdout.Dispose();
            stderr.Dispose();

            return $"Для запуска отправителя в контейнере {containerName} в командной строке контейнера введите: python {path}/sender.py";
        }

        // Function to transfer python file of reciever example to server
        public static string ServerTransferExampleReciever(string host, string user, string password, int port = 5672, string path = "/etc/rabbitmq")
        {
            string python_script = "import pika, sys, os\n\n" +
                    "def main():\n    " +
                    "connection = pika.BlockingConnection(pika.ConnectionParameters(host=\"localhost\", port=" + port.ToString() +
                    "))\n    " +
                    "channel = connection.channel()\n\n    " +
                    "channel.queue_declare(queue=\"hello\")\n\n    " +
                    "def callback(ch, method, properties, body):\n        " +
                    "print(\" [x] Received %r\" % body)\n\n    " +
                    "channel.basic_consume(queue=\"hello\", on_message_callback=callback, auto_ack=True)\n\n    " +
                    "print(\" [*] Waiting for messages. To exit press CTRL+C\")\n    " +
                    "channel.start_consuming()\n\n" +
                    "if __name__ == \"__main__\":\n    " +
                    "try:\n        " +
                    "main()\n    " +
                    "except KeyboardInterrupt:\n        " +
                    "print(\"Interrupted\")\n        " +
                    "try:\n            " +
                    "sys.exit(0)\n        " +
                    "except SystemExit:\n            " +
                    "os._exit(0)";

            var sshClient = new SshClient(host, user, password);

            try
            {
                sshClient.Connect();
            }
            catch
            {
                return $"Невозможно подключиться к серверу {host} по введённым данным";
            }

            ShellStream shellStream = sshClient.CreateShellStream("shell", 200, 24, 1920, 1080, 4096);

            shellStream.WriteLine($"sudo -i");
            shellStream.Flush();

            shellStream.WriteLine(password);
            shellStream.Flush();
            Thread.Sleep(500);

            shellStream.WriteLine($"echo \'{python_script}\' > {path}/reciever.py");
            shellStream.Flush();

            Thread.Sleep(500);

            shellStream.Dispose();

            sshClient.Disconnect();

            return $"Для запуска скрипта получателя на сервере {host} введите в терминале: python {path}/reciever.py";
        }

        // Function to transfer python file of sender example to server
        public static string ServerTransferExampleSender(string host, string user, string password, int port = 5672, string path = "/etc/rabbitmq")
        {
            string python_script = "import pika\n\n" +
                    "connection = pika.BlockingConnection(pika.ConnectionParameters(host=\"localhost\", port=" + port.ToString() +
                    "))\n\n" +
                    "channel = connection.channel()\n\n" +
                    "channel.queue_declare(queue=\"hello\")\n\n" +
                    "channel.basic_publish(exchange=\"\", routing_key=\"hello\", body=\"Example message\")\n" +
                    "print(\" [x] Sent \'Example message\'\")\n" +
                    "connection.close()";

            var sshClient = new SshClient(host, user, password);

            try
            {
                sshClient.Connect();
            }
            catch
            {
                return $"Невозможно подключиться к серверу {host} по введённым данным";
            }

            ShellStream shellStream = sshClient.CreateShellStream("shell", 200, 24, 1920, 1080, 4096);

            shellStream.WriteLine($"sudo -i");
            shellStream.Flush();

            shellStream.WriteLine(password);
            shellStream.Flush();
            Thread.Sleep(500);

            shellStream.WriteLine($"echo \'{python_script}\' > {path}/sender.py");
            shellStream.Flush();

            Thread.Sleep(500);

            shellStream.Dispose();

            sshClient.Disconnect();

            return $"Для запуска скрипта получателя на сервере {host} введите в терминале: python {path}/sender.py";
        }
    }
}
