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
    public partial class FinalStep : Form
    {
        
        public FinalStep()
        {
            InitializeComponent();
            btn_finish.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
            
        }

        //private async Task Configure()
        //{
            
        //}
        private void btnn_configure_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            
        }
    }
}
