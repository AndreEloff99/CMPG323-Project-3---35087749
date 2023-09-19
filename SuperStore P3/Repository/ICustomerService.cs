namespace EcoPower_Logistics.Repository
{
    public interface ICustomerService : IGenericRepository<CustomerRepository>
    {
        CustomerRepository GetCustomerRepository();
    }
}
