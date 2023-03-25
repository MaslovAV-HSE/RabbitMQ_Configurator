using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Бокеры_сообщений.Helpers;

namespace Бокеры_сообщений.Modules
{
    // Module to save all additional files like configuration saves or logs
    public static class AdditionalFilesSaver
    {
        public static void SaveLogs(string content)
        {
            string path = Directory.GetCurrentDirectory() + $"\\LogFiles";
            if (Directory.Exists(path))
            {
                string filePath = path + $"\\{DateTime.Now}_{ConfigurationHelper.configurationName}_log.txt";

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }
        }

        public static void SaveConfiguration()
        {

        }
    }
}
