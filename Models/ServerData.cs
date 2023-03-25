using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бокеры_сообщений.Models
{
    public class ServerData
    {
        public string IpAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }    
        public int Port { get; set; }

        public ServerData(string ipAddress, string userName, string password, int port)
        {
            IpAddress = ipAddress;
            UserName = userName;
            Password = password;
            Port = port;
        }
    }
}
