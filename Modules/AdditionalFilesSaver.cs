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

        private static string FormatNodes()
        {
            if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Server)
            {
                return $"\"nodes\": {JsonConvert.SerializeObject(ConfigurationHelper.serverList, settings)},\n";
            }

            else if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Container)
            {
                return $"\"nodes\": {JsonConvert.SerializeObject(ConfigurationHelper.containerList, settings)},\n";
            }

            else
            {
                return $"\"nodes\": [],\n";
            }
        }

        private static string FormatOptions()
        {
            string content = "";

            content = content + $"\"networkOptions\": {JsonConvert.SerializeObject(ConfigurationHelper.networkOptions, settings)},\n";
            content = content + $"\"userOptions\": {JsonConvert.SerializeObject(ConfigurationHelper.userOptions, settings)},\n";
            content = content + $"\"additionalOptions\": {JsonConvert.SerializeObject(ConfigurationHelper.additionalOptions, settings)},\n";
            content = content + $"\"resourceOptions\": {JsonConvert.SerializeObject(ConfigurationHelper.resourceOptions, settings)},\n";
            content = content + $"\"statisticsOptions\": {JsonConvert.SerializeObject(ConfigurationHelper.statistcsOptions, settings)},\n";

            return content;
        }

        public static string SaveConfiguration()
        {
            string path = Directory.GetCurrentDirectory() + "\\SaveFiles";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = path + $"\\{DateTime.Now}_{ConfigurationHelper.configurationName}.json";
            string content = "{ \n";

            content = content + $"\"configurationName\": {JsonConvert.SerializeObject(ConfigurationHelper.configurationName, settings)},\n";

            if (ConfigurationHelper.nodeType == ConfigurationHelper.NodeType.Server)
            {
                content = content + $"\"nodeType\": {JsonConvert.SerializeObject("Server", settings)},\n";
            }
            else
            {
                content = content + $"\"nodeType\": {JsonConvert.SerializeObject("Container", settings)},\n";
            }

            content = content + FormatNodes();
            content = content + FormatOptions();

            return content + "\n}";
        }
    }
}
