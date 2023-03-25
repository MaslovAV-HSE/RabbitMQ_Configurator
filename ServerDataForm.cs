using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Бокеры_сообщений
{
    public partial class ServerDataForm : Form
    {
        public ServerDataForm()
        {
            InitializeComponent();
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBox = MessageBoxButtons.YesNo;
            MessageBox.Show("Новая конфигурация?", "Выберите настройку!", messageBox, MessageBoxIcon.Question);
            
        }
    }
}
