using System.Net.Http;
using System.Threading.Tasks;

namespace ECommerce.Core.DataAccess
{
    public interface IHttpRepository<TEntity> where TEntity : class, new()
    {
        Task<TEntity> GetJsonAsync(string uri);

        Task<HttpResponseMessage> PutJsonAsync<T>(string uri, T data);
    }
}