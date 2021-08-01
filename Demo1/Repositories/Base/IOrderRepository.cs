using Demo1.Entities;

namespace Demo1.Repositories.Base
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}