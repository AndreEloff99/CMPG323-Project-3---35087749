using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository : GenericRepository<IProductService>
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public ProductRepository(SuperStoreContext context) : base(context) 
        { }

        //The Get All for Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();  
        }
    }
}
