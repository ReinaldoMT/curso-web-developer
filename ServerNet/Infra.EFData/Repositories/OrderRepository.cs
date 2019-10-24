using Domain.Interfaces;
using Domain.Models;

namespace Infra.EFData.Repositories
{
    public class OrderRepository : AbstractRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
