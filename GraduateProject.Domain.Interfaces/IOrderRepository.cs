using GraduateProject.Domain.Core;

namespace GraduateProject.Domain.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        void DeleteOrder(Guid id);
        Order GetOrder(Guid id);
        IEnumerable<Order> GetOrders();
        void UpdateOrder(Order order);
    }
}
