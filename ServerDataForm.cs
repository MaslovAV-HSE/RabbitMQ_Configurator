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
            textBox3.Text = server.IpAddress;
            textBox2.Text = server.UserName;
            textBox1.Text = server.Password;
            textBox4.Text = server.Port.ToString();
            s = server;
            editMode= true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                if (editMode)
                {
                    s.IpAddress = textBox3.Text;
                    s.UserName = textBox2.Text;
                    s.Password = textBox1.Text;
                    s.Port = Convert.ToInt32(textBox4.Text);
                }
                else {
                    ConfigurationHelper.serverList.Add(
                            new Models.ServerData(textBox3.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text)));
                }

                    
                this.DialogResult = DialogResult.OK;
                this.Owner.Show();
            }
        }

        private bool CheckData()
        {
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; this.Owner.Show();
        }
    }
}
