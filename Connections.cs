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

namespace Бокеры_сообщений
{
    public partial class Connections : Form
    {
        public Connections()
        {
            InitializeComponent();
            dataGridView1.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect=false;
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ConfigurationHelper.RollbackNodeListsChanges();
            this.Owner.Show();
            this.Close();
        }

        private void btd_del_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить данные", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i ++)
            {                 
                if (result == DialogResult.Yes)
                {
                    if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Server)
                        ConfigurationHelper.serverList.Remove((Models.ServerData)dataGridView1.SelectedRows[i].DataBoundItem);
                    else
                        ConfigurationHelper.containerList.Remove((Models.ContainerData)dataGridView1.SelectedRows[i].DataBoundItem);
                }
            }

            DataUpdate();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Server)
            {
                Models.ServerData server = (Models.ServerData)dataGridView1.SelectedRows[0].DataBoundItem;
                ServerDataForm sd = new ServerDataForm(ref server);
                sd.Owner = this;
                this.Hide();
                sd.ShowDialog();
                DataUpdate();
            }
            else
            {
                Models.ContainerData container = (Models.ContainerData)dataGridView1.SelectedRows[0].DataBoundItem;
                ContainerDataForm cd = new ContainerDataForm(ref container);
                cd.Owner = this;
                this.Hide();
                cd.ShowDialog();
                DataUpdate();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Server)
            {
                ServerDataForm sd = new ServerDataForm();
                sd.Owner = this;
                this.Hide();
                sd.ShowDialog();
                
            }
            else
            {
                ContainerDataForm cd = new ContainerDataForm();
                cd.Owner = this;
                this.Hide();
                cd.ShowDialog();
                
            }
            DataUpdate();
        }

        public void DataUpdate()
        {
            BindingSource bindingSource = new BindingSource();
            if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Container)
                bindingSource.DataSource = ConfigurationHelper.containerList;
            else
                bindingSource.DataSource = ConfigurationHelper.serverList;
            dataGridView1.DataSource = bindingSource;
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Пожалуйста заполните список узлов", "Список узлов пуст", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var Final = new FinalStep();
                this.Close();
                Final.Show();
            }        
        }

        private void Connections_Load(object sender, EventArgs e)
        {
            ConfigurationHelper.SaveListsState();
            BindingSource bindingSource = new BindingSource();
            dataGridView1.AutoGenerateColumns = true;
            if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Server)
            {
                bindingSource.DataSource = ConfigurationHelper.serverList;
                node_type.Text = "Сервер";
            }
            else
            {
                bindingSource.DataSource = ConfigurationHelper.containerList;
                node_type.Text = "Контейнер";
            }
                
            dataGridView1.DataSource = bindingSource;

            if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Server)
            {
                dataGridView1.Columns[0].HeaderText = "IP адрес";
                dataGridView1.Columns[1].HeaderText = "Пароль";
                dataGridView1.Columns[2].HeaderText = "Логин";
                dataGridView1.Columns[3].HeaderText = "Порт";
            }
            else
            {
                dataGridView1.Columns[0].HeaderText = "Имя";
                dataGridView1.Columns[1].HeaderText = "Порт";
            }

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
