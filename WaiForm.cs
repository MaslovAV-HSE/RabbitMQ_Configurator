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
    public partial class WaiForm : Form
    {
        public WaiForm()
        {
            InitializeComponent();

            label1.Text = "Подождите...\nИдёт процесс по обновлению конфигурации RabbitMQ";
        }

        private void WaiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
