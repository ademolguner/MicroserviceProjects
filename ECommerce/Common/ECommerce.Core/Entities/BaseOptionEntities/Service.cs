namespace ECommerce.Core.Entities.BaseOptionEntities
{
    public class Service
    {
        public string ServiceName { get; set; }
        public string ServiceUrl { get; set; }
        public string Port { get; set; }
        public string ServicePath => $"http://{ServiceUrl}:{Port}";
    }
}