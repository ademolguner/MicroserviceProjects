using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Entities.BaseOptionEntities
{
    public class RabbitMq
    {
        public string HostName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
    }
}
