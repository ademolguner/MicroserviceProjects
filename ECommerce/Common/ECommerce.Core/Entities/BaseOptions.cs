using ECommerce.Core.Utilities.ApiServices;
using ECommerce.Core.Utilities.Caching.Redis;
using ECommerce.Core.Utilities.MessageQueue.RabbitMq;
using ECommerce.Core.Utilities.Security.Jwt;

namespace InfoQ.Core.Entities
{
    public class BaseOptions
    {
        public Redis Redis { get; set; }
        public TokenOptions TokenOptions { get; set; }
        public RabbitMq RabbitMq { get; set; }
        public Service[] Services { get; set; }
    }
}