using Controllers;
using Data;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public class CustomerRepository : GenericRepository<ICustomerService>
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public CustomerRepository(SuperStoreContext context) : base(context)
        { }

        //The Get All for Customer
        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }
    }
}
