using Domain.Interfaces;
using Domain.Models;

namespace Infra.EFData.Repositories
{
    public class OrderItemRepository : AbstractRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
