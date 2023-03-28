﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Бокеры_сообщений.Helpers;
using Бокеры_сообщений.Modules;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Бокеры_сообщений
{
    public partial class FinalStep : Form
    {
        
        public FinalStep()
        {
            InitializeComponent();
            btn_finish.Enabled = true;
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void FinalStep_Load(object sender, EventArgs e)
        {
            label1.Text += $" {ConfigurationHelper.configurationName}";
            if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Server)
                node_type.Text = "Сервер";
            else
                node_type.Text = "Контейнер";

            var conFile = RabbitMQConfigurationFormatter.CreateConfigurationFile();
            if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Server)
            {
                foreach (var server in ConfigurationHelper.serverList)
                {
                    var content = $"listeners.tcp.default = {server.Port}" + "\n" + conFile;
                    var conResult = RabbitMQFileTransferer.ServerTransferConfigurationFile(server.IpAddress, server.UserName, server.Password, content);
                    var recieverResult = RabbitMQFileTransferer.ServerTransferExampleReciever(server.IpAddress, server.UserName, server.Password, server.Port);
                    var senderResult = RabbitMQFileTransferer.ServerTransferExampleSender(server.IpAddress, server.UserName, server.Password, server.Port);

                    statusTextBox.Text += $"Сервер: {server.IpAddress} \n{conResult}\n{recieverResult}\n{senderResult}\n\n";
                }
            }
            else
            {
                foreach (var container in ConfigurationHelper.containerList)
                {
                    var content = $"listeners.tcp.default = {container.Port}" + "\n" + conFile;
                    statusTextBox.Text += "Для использования настроенных серверов RabbitMQ в контейнерах необходимо сначала их перезагрузить\n\n";

                    try
                    {
                        var conResult = await RabbitMQFileTransferer.ContainerTransferConfigurationFile(container.ContainerName, content);
                        var recieverResult = await RabbitMQFileTransferer.ContainerTransferExampleReciever(container.ContainerName, container.Port);
                        var senderResult = await RabbitMQFileTransferer.ContainerTransferExampleSender(container.ContainerName);

                        statusTextBox.Text += $"Контейнер: {container.ContainerName} \n{conResult}\n{recieverResult}\n{senderResult}\n\n";
                    }
                    catch
                    {
                        statusTextBox.Text += $"Невозможно подключиться к контейнеру {container.ContainerName}\n\n";
                    }
                }
            }
        }

        private void save_log_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog.FileName;
            // сохраняем текст в файл
            File.WriteAllText(filename, statusTextBox.Text);
        }

        private void save_conf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json files (*.json)|*.json";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog.FileName;
            // сохраняем текст в файл
            File.WriteAllText(filename, AdditionalFilesSaver.SaveConfiguration());
        }
    }
}
