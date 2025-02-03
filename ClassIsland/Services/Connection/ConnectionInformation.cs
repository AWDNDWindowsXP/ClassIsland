using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassIsland.Services.Connection
{
    public class ConnectionInfo
    {
        public string IpAddress { get; set; } = Dns.GetHostAddresses(Dns.GetHostName()).ToString();
    }
}
