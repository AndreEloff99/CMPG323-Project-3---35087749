using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderService
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

            //The Get All for Order
        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }
        
    }
}
