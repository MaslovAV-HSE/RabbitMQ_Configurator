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
    public partial class ServerDataForm : Form
    {
        Models.ServerData s = new Models.ServerData("", "", "", 1);
        bool editMode = false;
        public ServerDataForm()
        {
            InitializeComponent();
        }

        public ServerDataForm(ref Models.ServerData server)
        {
            InitializeComponent();
            tbIP.Text = server.IpAddress;
            tbLog.Text = server.UserName;
            tbPass.Text = server.Password;
            tbPort.Text = server.Port.ToString();
            s = server;
            editMode= true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                if (editMode)
                {
                    s.IpAddress = tbIP.Text;
                    s.UserName = tbLog.Text;
                    s.Password = tbPass.Text;
                    s.Port = Convert.ToInt32(tbPort.Text);
                }
                else {
                    ConfigurationHelper.serverList.Add(
                            new Models.ServerData(tbIP.Text, tbLog.Text, tbIP.Text, Convert.ToInt32(tbPort.Text)));
                }

                    
                this.DialogResult = DialogResult.OK;
                this.Owner.Show();
            }
            else
                MessageBox.Show("Некоректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckData()
        {
            if (!String.IsNullOrWhiteSpace(tbIP.Text) && !String.IsNullOrWhiteSpace(tbLog.Text) &&
                !String.IsNullOrWhiteSpace(tbPass.Text) && int.TryParse(tbPort.Text, out int port)) return true;
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; this.Owner.Show();
        }

        private void ServerDataForm_Load(object sender, EventArgs e)
        {

        }
    }
}
