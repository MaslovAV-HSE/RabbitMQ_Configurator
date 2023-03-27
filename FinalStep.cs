using System;
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

namespace Бокеры_сообщений
{
    public partial class FinalStep : Form
    {
        
        public FinalStep()
        {
            InitializeComponent();
            btn_finish.Enabled = false;
        }


        private void btn_finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_begin_Click(object sender, EventArgs e)
        {
            ConfigurationHelper.ClearAllConfiguration();
            this.Close();
        }

        private void FinalStep_Load(object sender, EventArgs e)
        {
            label1.Text += $" {ConfigurationHelper.configurationName}";
            if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Server)
                label2.Text += " Сервер";
            else
                label2.Text += " Контейнер";

            var conFile = RabbitMQConfigurationFormatter.CreateConfigurationFile();
            if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Server)
            {
                foreach (var server in ConfigurationHelper.serverList)
                {
                    var content = $"listeners.tcp.default = {server.Port}" + conFile;
                    var conResult = RabbitMQFileTransferer.ServerTransferConfigurationFile(server.IpAddress, server.UserName, server.Password, content);
                    var recieverResult = RabbitMQFileTransferer.ServerTransferExampleReciever(server.IpAddress, server.UserName, server.Password, server.Port);
                    var senderResult = RabbitMQFileTransferer.ServerTransferExampleSender(server.IpAddress, server.UserName, server.Password, server.Port);

                    statusTextBox.Text += $"server: {server.IpAddress} \n{conResult}\n{recieverResult}\n{senderResult}";
                }
            }
            else
            {
                foreach (var conteiner in ConfigurationHelper.containerList)
                {
                    var content = $"listeners.tcp.default = {conteiner.Port}" + conFile;
                    var conResult = RabbitMQFileTransferer.ContainerTransferConfigurationFile(conteiner.ContainerName, conFile);
                    var recieverResult = RabbitMQFileTransferer.ContainerTransferExampleReciever(conteiner.ContainerName, conteiner.Port);
                    var senderResult = RabbitMQFileTransferer.ContainerTransferExampleSender(conteiner.ContainerName);
                    

                    statusTextBox.Text += $"conteiner: {conteiner.ContainerName} \n{conResult}\n{recieverResult}\n{senderResult}";
                }
            }
            AdditionalFilesSaver.SaveConfiguration();
            AdditionalFilesSaver.SaveLogs(statusTextBox.Text);
        }


    }
}
