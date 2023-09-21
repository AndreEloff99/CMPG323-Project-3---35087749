namespace EcoPower_Logistics.Repository
{
    public interface IProductService : IGenericRepository<ProductRepository>
    {
        ProductRepository GetAll();
    }
}
