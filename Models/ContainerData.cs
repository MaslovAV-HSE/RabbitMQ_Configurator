using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бокеры_сообщений.Models
{
    public class ContainerData
    {
        // Name of container
        public string ContainerName { get; set; }   
        // Port where rabbitmq service will be running
        public int Port { get; set; }

        // Constructor
        public ContainerData(string containerName, int port)
        {
            ContainerName = containerName;
            Port = port;
        }
    }
}
