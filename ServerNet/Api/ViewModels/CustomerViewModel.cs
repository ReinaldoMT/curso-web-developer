using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModels
{
    public class CustomerViewModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
