namespace EcoPower_Logistics.Repository
{
    public interface IOrderService : IGenericRepository<OrderRepository>
    {
        OrderRepository GetOrderRepository();
    }
}
