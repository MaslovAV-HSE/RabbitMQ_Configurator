using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Бокеры_сообщений.Models;

namespace Бокеры_сообщений.Helpers
{
    // static variables about configuration will be stored here to use them in different forms
    public static class ConfigurationHelper
    {
        // Node type (container or server)
        public enum NodeType
        {
            Server,
            Container
        }

        // Variables to store basic options like name or Node Type
        public static string configurationName = "";
        public static NodeType nodeType = NodeType.Server;
        
        // List to store all current options
        public static List<ConfigurationOption> networkOptions = new List<ConfigurationOption>();
        public static List<ConfigurationOption> userOptions = new List<ConfigurationOption>();
        public static List<ConfigurationOption> additionalOptions = new List<ConfigurationOption>();
        public static List<ConfigurationOption> resourceOptions = new List<ConfigurationOption>();
        public static List<ConfigurationOption> statistcsOptions = new List<ConfigurationOption>();

        // Lists to store all nodes like servers or containers
        public static List<ServerData> serverList = new List<ServerData>();
        public static List<ContainerData> containerList = new List<ContainerData>();

        // Lists to store all nodes like servers or containers (their previous state)
        private static List<ServerData> prevServerList = new List<ServerData>();
        private static List<ContainerData> prevContainerList = new List<ContainerData>();

        // Variable to store content of configuration file
        public static string ConfigContent = "";

        // Function to save state of nodes lists
        public static void SaveListsState()
        {
            prevServerList.Clear();
            prevContainerList.Clear();

            prevContainerList.AddRange(containerList);
            prevServerList.AddRange(serverList);
        }

        // Clear all configuration that was done
        public static void ClearAllConfiguration()
        {
            configurationName = "";

            networkOptions.Clear();
            networkOptions.Clear();
            networkOptions.Clear();
            networkOptions.Clear();
            networkOptions.Clear();

            serverList.Clear();
            containerList.Clear();
        }

        // Rollback node lists changes
        public static void RollbackNodeListsChanges()
        {
            serverList.Clear();
            containerList.Clear();

            serverList.AddRange(prevServerList);
            containerList.AddRange(prevContainerList);
        }
    }
}
