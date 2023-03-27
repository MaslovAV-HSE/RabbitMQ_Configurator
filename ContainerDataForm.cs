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
            tbName.Text = container.ContainerName;
            tbPort.Text = container.Port.ToString();
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
                    data.ContainerName = tbName.Text;
                    data.Port = Convert.ToInt32(tbPort.Text);
                }
                else
                {
                    ConfigurationHelper.containerList.Add(new Models.ContainerData(tbName.Text, Convert.ToInt32(tbPort.Text)));
                }
                this.DialogResult = DialogResult.OK;
                this.Owner.Show();
                
            }
            else
                MessageBox.Show("Некоректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        private bool CheckData()
        {
            if (!String.IsNullOrWhiteSpace(tbName.Text) && int.TryParse(tbPort.Text, out int port))
                return true;
            return false;
    
        }

        private void ContainerDataForm_Load(object sender, EventArgs e)
        {

        }
    }
}
