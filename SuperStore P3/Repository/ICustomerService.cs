using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public interface ICustomerService : IGenericRepository<CustomerRepository>
    {
        CustomerRepository GetCustomerRepository();
        CustomerRepository GetById(int id);
        IEnumerable<CustomerRepository> GetAll();
        IEnumerable<CustomerRepository> Find(Expression<Func<CustomerRepository, bool>> expression);
        void Add(CustomerRepository entity);
        void AddRange(IEnumerable<CustomerRepository> entities);
        void Remove(CustomerRepository entity);
        void RemoveRange(IEnumerable<CustomerRepository> entities);
    }
}
