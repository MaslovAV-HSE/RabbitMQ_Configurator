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
            //РЕАЛИЗОВАТЬ
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
    }
}
