using Data;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public interface ICustomerService : IGenericRepository<CustomerRepository>
    {
        CustomerRepository GetAll();
    }
}
