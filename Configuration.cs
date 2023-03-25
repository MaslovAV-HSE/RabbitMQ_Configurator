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

namespace Бокеры_сообщений
{
    public partial class Configuration : Form
    {
        private string filepath;

        Dictionary<int, string[]> group1 = new Dictionary<int, string[]>{
            {0, new string[]{"наименование 1", "описание 1"} },
            {1, new string[]{"наименование 2", "описание 2"} },
            {2, new string[]{"наименование 3", "описание 3"} }
        };
        public Configuration()
        {
            InitializeComponent();
        }

        public Configuration(string filepath)
        {
            InitializeComponent();
            this.filepath = filepath;
            //РЕАЛИЗОВАТЬ
        }

        private void newGoup(int num)
        {
            //РЕАЛИЗОВАТЬ
            foreach (var item in group1)
            {
                var name = new Label();
                var description = new Label();
                var input = new TextBox();

            }
        }

        private void SaveChanges()
        {
            ConfigurationHelper.networkOptions[0].Value = networkTB1.Text;
            ConfigurationHelper.networkOptions[1].Value = networkTB2.Text;
            ConfigurationHelper.networkOptions[2].Value = networkTB3.Text;
            ConfigurationHelper.networkOptions[3].Value = networkCB4.SelectedItem.ToString();

            ConfigurationHelper.userOptions[0].Value = userCB1.SelectedItem.ToString();
            ConfigurationHelper.userOptions[1].Value = userTB2.Text;
            ConfigurationHelper.userOptions[2].Value = userTB3.Text;
            ConfigurationHelper.userOptions[3].Value = userTB4.Text;

            ConfigurationHelper.additionalOptions[0].Value = additionalTB1.Text;
            ConfigurationHelper.additionalOptions[1].Value = additionalTB2.Text;
            ConfigurationHelper.additionalOptions[2].Value = additionalTB3.Text;
            ConfigurationHelper.additionalOptions[3].Value = additionalTB4.Text;

            ConfigurationHelper.resourceOptions[0].Value = resoursesTB1.Text;
            ConfigurationHelper.resourceOptions[1].Value = resoursesTB2.Text;
            ConfigurationHelper.resourceOptions[2].Value = resoursesTB3.Text;

            ConfigurationHelper.statistcsOptions[0].Value = statisticTB1.Text;

            ConfigurationHelper.configurationName = configName.Text;
            if (connectionType.SelectedIndex == 0)
                ConfigurationHelper.nodeType = ConfigurationHelper.NodeType.Server;
            else
                ConfigurationHelper.nodeType = ConfigurationHelper.NodeType.Container;


        }

        private void Configuration_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            var Connect = new Connections();
            Connect.Owner = this;
            this.Hide();
            Connect.ShowDialog();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            ConfigurationLoader.LoadConfiguration("C:\\Users\\Maslov Alexander\\Source\\Repos\\RabbitMQ_Configurator\\Docs\\deafaultConfig.json");

            //Сеть
            label1.Text = ConfigurationHelper.networkOptions[0].InterfaceName;
            label2.Text = ConfigurationHelper.networkOptions[0].Description;
            networkTB1.Text = ConfigurationHelper.networkOptions[0].Value;

            label4.Text = ConfigurationHelper.networkOptions[1].InterfaceName;
            label3.Text = ConfigurationHelper.networkOptions[1].Description;
            networkTB2.Text = ConfigurationHelper.networkOptions[1].Value;

            label6.Text = ConfigurationHelper.networkOptions[2].InterfaceName;
            label5.Text = ConfigurationHelper.networkOptions[2].Description;
            networkTB3.Text = ConfigurationHelper.networkOptions[2].Value;

            label8.Text = ConfigurationHelper.networkOptions[3].InterfaceName;
            label7.Text = ConfigurationHelper.networkOptions[3].Description;
            networkCB4.SelectedItem = networkCB4.Items[0];


            //Доступ 
            label9.Text = ConfigurationHelper.userOptions[0].InterfaceName;
            label16.Text = ConfigurationHelper.userOptions[0].Description;
            userCB1.SelectedItem = userCB1.Items[0];

            label15.Text = ConfigurationHelper.userOptions[1].InterfaceName;
            label16.Text = ConfigurationHelper.userOptions[1].Description;
            userTB2.Text = ConfigurationHelper.userOptions[1].Value;

            label13.Text = ConfigurationHelper.userOptions[2].InterfaceName;
            label12.Text = ConfigurationHelper.userOptions[2].Description;
            userTB3.Text = ConfigurationHelper.userOptions[2].Value;

            label11.Text = ConfigurationHelper.userOptions[3].InterfaceName;
            label10.Text = ConfigurationHelper.userOptions[3].Description;
            userTB4.Text = ConfigurationHelper.userOptions[3].Value;
            
            //Дополнительные
            label17.Text = ConfigurationHelper.additionalOptions[0].InterfaceName;
            label24.Text = ConfigurationHelper.additionalOptions[0].Description;
            additionalTB1.Text = ConfigurationHelper.additionalOptions[0].Value;

            label23.Text = ConfigurationHelper.additionalOptions[1].InterfaceName;
            label22.Text = ConfigurationHelper.additionalOptions[1].Description;
            additionalTB2.Text = ConfigurationHelper.additionalOptions[1].Value;

            label21.Text = ConfigurationHelper.additionalOptions[2].InterfaceName;
            label20.Text = ConfigurationHelper.additionalOptions[2].Description;
            additionalTB3.Text = ConfigurationHelper.additionalOptions[2].Value;

            label19.Text = ConfigurationHelper.additionalOptions[3].InterfaceName;
            label18.Text = ConfigurationHelper.additionalOptions[3].Description;
            additionalTB4.Text = ConfigurationHelper.additionalOptions[3].Value;

            //Ресурсы
            label25.Text = ConfigurationHelper.resourceOptions[0].InterfaceName;
            label32.Text = ConfigurationHelper.resourceOptions[0].Description;
            resoursesTB1.Text = ConfigurationHelper.resourceOptions[0].Value;

            label31.Text = ConfigurationHelper.resourceOptions[1].InterfaceName;
            label30.Text = ConfigurationHelper.resourceOptions[1].Description;
            resoursesTB2.Text = ConfigurationHelper.resourceOptions[1].Value;

            label29.Text = ConfigurationHelper.resourceOptions[2].InterfaceName;
            label28.Text = ConfigurationHelper.resourceOptions[2].Description;
            resoursesTB3.Text = ConfigurationHelper.resourceOptions[2].Value;

            //Статистика
            label33.Text = ConfigurationHelper.statistcsOptions[0].InterfaceName;
            label40.Text = ConfigurationHelper.statistcsOptions[0].Description;
            statisticTB1.Text = ConfigurationHelper.statistcsOptions[0].Value;

            //основные
            connectionType.SelectedItem = connectionType.Items[0];
        }   
    }
}
