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
    public partial class ContainerDataForm : Form
    {
        Models.ContainerData data;
        bool editMode = false;
        public ContainerDataForm()
        {
            InitializeComponent();
        }

        public ContainerDataForm(ref Models.ContainerData container)
        {
            InitializeComponent();
            textBox1.Text = container.ContainerName;
            textBox2.Text = container.Port.ToString();
            data = container;
            editMode= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                if (editMode) {
                    data.ContainerName = textBox1.Text;
                    data.Port = Convert.ToInt32(textBox2.Text);
                }
                else
                {
                    ConfigurationHelper.containerList.Add(new Models.ContainerData(textBox1.Text, Convert.ToInt32(textBox2.Text)));
                }
                this.Owner.Show();
                this.DialogResult= DialogResult.OK;
            }
            
        }
        private bool CheckData()
        {
            return true;
        }

        private void ContainerDataForm_Load(object sender, EventArgs e)
        {

        }
    }
}
