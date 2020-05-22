using System.Threading.Tasks;

namespace ECommerce.Core.DataAccess.Mongo
{
    public interface IDatabaseSeeder
    {
        Task SeedAsync();
    }
}