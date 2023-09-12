using Homework6CMPG_323.Data;
using Homework6CMPG_323.Models;

namespace Homework6CMPG_323.Repository
{
    public class ProductRepository
    {
        protected readonly Homework_6Context _context = new Homework_6Context();

        // GET ALL: Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’

    }
}
