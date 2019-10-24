using Domain.Interfaces;
using Domain.Models;

namespace Infra.EFData.Repositories
{
    public class CustomerRepository : AbstractRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
