using System.Windows.Forms;
using Бокеры_сообщений.Helpers;
using Бокеры_сообщений.Modules;

namespace Бокеры_сообщений
{
    public partial class StartForm : Form
    {
        
        public StartForm()
        {
            InitializeComponent();
        }

        private bool CheckFile(string path)
        {
            try
            {
                ConfigurationLoader.LoadConfiguration(path);
                return true;
            }
            catch
            {
                return false;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Json files (*.json)|*.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!CheckFile(openFileDialog.FileName))
                    {
                        MessageBox.Show("Проверьте правильность файла конфигурации", "Ошибка при чтении файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BaseHelper.LoadedConfig = true;
                        var Config = new Configuration();
                        Config.Owner = this;
                        this.Hide();
                        Config.Show();
                    }
                }
            }     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigurationLoader.LoadConfiguration(Directory.GetCurrentDirectory() + "\\Docs\\deafaultConfig.json"); 
            var Config = new Configuration();
            Config.Owner= this;
            this.Hide();
            Config.Show();
        }
    }
}