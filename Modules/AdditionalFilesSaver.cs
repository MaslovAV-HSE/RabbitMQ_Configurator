using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Бокеры_сообщений.Helpers;
using Microsoft.VisualBasic.Devices;

namespace Бокеры_сообщений.Modules
{
    // Module to save all additional files like configuration saves or logs
    public static class AdditionalFilesSaver
    {
        private static DefaultContractResolver contractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy()
        };

        private static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            ContractResolver = contractResolver,
            Formatting = Formatting.Indented
        };

        public static void SaveLogs(string content)
        {
            string path = Directory.GetCurrentDirectory() + $"\\LogFiles";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = path + $"\\{DateTime.Now}_{ConfigurationHelper.configurationName}_log.txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(content);
            }
        }

        private static string FormatNodes()
        {
            if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Server)
            {
                return $"\"nodes\": {JsonConvert.SerializeObject(ConfigurationHelper.serverList, settings)},";
            }

            else if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Container)
            {
                return $"\"nodes\": {JsonConvert.SerializeObject(ConfigurationHelper.containerList, settings)},";
            }

            else
            {
                return $"\"nodes\": [],";
            }
        }

        private static string FormatOptions()
        {
            string content = "";

            content = content + $"\"networkOptions\": {JsonConvert.SerializeObject(ConfigurationHelper.networkOptions, settings)},";
            content = content + $"\"userOptions\": {JsonConvert.SerializeObject(ConfigurationHelper.userOptions, settings)},";
            content = content + $"\"additionalOptions\": {JsonConvert.SerializeObject(ConfigurationHelper.additionalOptions, settings)},";
            content = content + $"\"resourceOptions\": {JsonConvert.SerializeObject(ConfigurationHelper.resourceOptions, settings)},";
            content = content + $"\"statisticsOptions\": {JsonConvert.SerializeObject(ConfigurationHelper.statistcsOptions, settings)},";

            return content;
        }

        public static void SaveConfiguration()
        {
            string path = Directory.GetCurrentDirectory() + "\\SaveFiles";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = path + $"\\{DateTime.Now}_{ConfigurationHelper.configurationName}.json";
            string content = "";

            content = content + $"\"configurationName\": {JsonConvert.SerializeObject(ConfigurationHelper.configurationName, settings)},";
            content = content + $"\"nodeType\": {JsonConvert.SerializeObject(ConfigurationHelper.nodeType, settings)},";

            content = content + FormatNodes();
            content = content + FormatOptions();

            File.WriteAllText(path, content);
        }
    }
}
