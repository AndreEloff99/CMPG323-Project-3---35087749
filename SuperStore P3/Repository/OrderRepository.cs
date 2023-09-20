using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderRepository : GenericRepository<IOrderService>
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public OrderRepository(SuperStoreContext context) : base(context)
        { }
            //The Get All for Order
        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }
        
    }
}
