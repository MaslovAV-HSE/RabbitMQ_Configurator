using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бокеры_сообщений.Models
{
    public class ConfigurationOption
    {
        // Name in rabbitmq config file
        public string ConfigurationName { get; set; }
        // UI name
        public string InterfaceName { get; set; }
        // Brief description
        public string Description { get; set; }
        // Value of this exact option
        public string Value { get; set; }

        // Constructor
        public ConfigurationOption(string configurationName, string interfaceName, string description, string value)
        {
            ConfigurationName = configurationName;
            InterfaceName = interfaceName;
            Description = description;
            Value = value;
        }
    }
}
