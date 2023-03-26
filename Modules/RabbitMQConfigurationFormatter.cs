using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Бокеры_сообщений.Helpers;

namespace Бокеры_сообщений.Modules
{
    // Module to from configuration file for RabbitMQ
    public static class RabbitMQConfigurationFormatter
    {
        public static string CreateConfigurationFile()
        {
            string content = "";

            foreach (var option in ConfigurationHelper.networkOptions)
            {
                content += $"{option.ConfigurationName} = {option.Value}\n";
            }

            foreach (var option in ConfigurationHelper.userOptions)
            {
                content += $"{option.ConfigurationName} = {option.Value}\n";
            }

            foreach (var option in ConfigurationHelper.additionalOptions)
            {
                content += $"{option.ConfigurationName} = {option.Value}\n";
            }

            foreach (var option in ConfigurationHelper.resourceOptions)
            {
                content += $"{option.ConfigurationName} = {option.Value}\n";
            }

            foreach (var option in ConfigurationHelper.statistcsOptions)
            {
                content += $"{option.ConfigurationName} = {option.Value}\n";
            }

            return content;
        }
    }
}
