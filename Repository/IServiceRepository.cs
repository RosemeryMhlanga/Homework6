using Homework6CMPG_323.Models;

namespace Homework6CMPG_323.Repository
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Service GetMostRecentService();
    }
}
