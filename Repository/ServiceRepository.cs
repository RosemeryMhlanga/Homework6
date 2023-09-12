using Homework6CMPG_323.Data;
using Homework6CMPG_323.Models;

namespace Homework6CMPG_323.Repository
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository(Homework_6Context context) : base(context)
        {
        }


        public Service GetMostRecentService()
        {
            return _context.Services.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }

    }
}
