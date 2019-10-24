using Domain.Interfaces;
using Domain.Models;

namespace Infra.EFData.Repositories
{
    public class ProductRepository : AbstractRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
