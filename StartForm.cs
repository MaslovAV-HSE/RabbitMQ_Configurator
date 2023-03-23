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
            return true;
            //РЕАЛИЗОВАТЬ
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    if (CheckFile(openFileDialog.FileName))
                    {
                        var Config = new Configuration(openFileDialog.FileName);
                        Config.Owner = this;
                        this.Hide();
                        Config.Show();
                    }
                    else
                    {
                        MessageBox.Show("Проверьте правильность файла конфигурации", "Ошибка при чтении файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Config = new Configuration();
            Config.Owner= this;
            this.Hide();
            Config.ShowDialog();
        }
    }
}