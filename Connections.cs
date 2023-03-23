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
    public partial class Connections : Form
    {
        public Connections()
        {
            InitializeComponent();
        }

        private void SaveChanges()
        {

        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            SaveChanges();
            this.Owner.Show();
            this.Close();

        }

        private void btd_del_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            var Final = new FinalStep();
            Final.Owner = this;
            this.Hide();
            Final.ShowDialog();
        }
    }
}
