using Domain.Models;

namespace Domain.Interfaces
{
    public interface ICustomerRepository : IAbstractRepository<Customer>
    {

    }

    public interface IOrderRepository : IAbstractRepository<Order>
    {

    }

    public interface IOrderItemRepository : IAbstractRepository<OrderItem>
    {

    }

    public interface IProductRepository : IAbstractRepository<Product>
    {

    }
}
