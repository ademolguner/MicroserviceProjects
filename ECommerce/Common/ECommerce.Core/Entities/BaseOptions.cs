using ECommerce.Core.Entities.BaseOptionEntities;

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