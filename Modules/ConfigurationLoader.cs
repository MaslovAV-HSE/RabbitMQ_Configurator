using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Бокеры_сообщений.Helpers;
using Бокеры_сообщений.Models;

namespace Бокеры_сообщений.Modules
{
    // Module to load previously made configurations
    public static class ConfigurationLoader
    {
        // Loading nodes from json file
        private static void LoadNodes(JObject jsonObject)
        {
            ConfigurationHelper.serverList = new List<ServerData>();
            ConfigurationHelper.containerList = new List<ContainerData>();   

            if ((string)jsonObject["nodeType"] == "Server")
            {
                ConfigurationHelper.nodeType = ConfigurationHelper.NodeType.Server;

                var nodes = jsonObject["nodes"];

                foreach (var node in nodes)
                {
                    ServerData data = new ServerData(
                        (string)node["ipAddress"],
                        (string)node["userName"], 
                        (string)node["password"], 
                        (int)node["port"]);
                    ConfigurationHelper.serverList.Add(data);
                }
            }
            else if ((string)jsonObject["nodeType"] == "Container")
            {
                ConfigurationHelper.nodeType = ConfigurationHelper.NodeType.Container;

                var nodes = jsonObject["nodes"];

                foreach (var node in nodes)
                {
                    ContainerData data = new ContainerData((string)node["containerName"], (int)node["port"]);
                    ConfigurationHelper.containerList.Add(data);
                }
            }
        }

        // Loading configuration options from json file
        private static void LoadConfigurationOptions(JObject jsonObject)
        {
            ConfigurationHelper.networkOptions = new List<ConfigurationOption>();
            ConfigurationHelper.userOptions = new List<ConfigurationOption>();
            ConfigurationHelper.additionalOptions = new List<ConfigurationOption>();
            ConfigurationHelper.resourceOptions = new List<ConfigurationOption>();
            ConfigurationHelper.statistcsOptions = new List<ConfigurationOption>();

            var networkOptions = jsonObject["networkOptions"];
            var userOptions = jsonObject["userOptions"];
            var additionalOptions = jsonObject["additionalOptions"];
            var resourceOptions = jsonObject["resourceOptions"];
            var statistcsOptions = jsonObject["statisticsOptions"];

            foreach (var option in networkOptions)
            {
                ConfigurationOption configurationOption = new ConfigurationOption(
                    (string)option["configurationName"], 
                    (string)option["interfaceName"], 
                    (string)option["description"], 
                    (string)option["value"]);

                ConfigurationHelper.networkOptions.Add(configurationOption);
            }

            foreach (var option in userOptions)
            {
                ConfigurationOption configurationOption = new ConfigurationOption(
                    (string)option["configurationName"],
                    (string)option["interfaceName"],
                    (string)option["description"],
                    (string)option["value"]);

                ConfigurationHelper.userOptions.Add(configurationOption);
            }

            foreach (var option in additionalOptions)
            {
                ConfigurationOption configurationOption = new ConfigurationOption(
                    (string)option["configurationName"],
                    (string)option["interfaceName"],
                    (string)option["description"],
                    (string)option["value"]);

                ConfigurationHelper.additionalOptions.Add(configurationOption);
            }

            foreach (var option in resourceOptions)
            {
                ConfigurationOption configurationOption = new ConfigurationOption(
                    (string)option["configurationName"],
                    (string)option["interfaceName"],
                    (string)option["description"],
                    (string)option["value"]);

                ConfigurationHelper.resourceOptions.Add(configurationOption);
            }

            foreach (var option in statistcsOptions)
            {
                ConfigurationOption configurationOption = new ConfigurationOption(
                    (string)option["configurationName"],
                    (string)option["interfaceName"],
                    (string)option["description"],
                    (string)option["value"]);

                ConfigurationHelper.statistcsOptions.Add(configurationOption);
            }
        }

        // Loading whole json file
        public static void LoadConfiguration(string path)
        {
            string json = File.ReadAllText(path);

            JObject jsonObject = JObject.Parse(json);

            ConfigurationHelper.configurationName = (string)jsonObject["configurationName"];

            LoadNodes(jsonObject);

            LoadConfigurationOptions(jsonObject);
        }
    }
}
