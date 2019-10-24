using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public abstract class Command
    {
        internal abstract bool IsValid();
        internal abstract List<string> ErrorMessages { get; set; }
    }

    public class StartDataCommand : Command
    {
        internal override List<string> ErrorMessages { get; set; } = new List<string>();

        internal override bool IsValid() => true;
        
    }

    public class FinalizeOrderCommand : Command
    {
        public Guid OrderId { get; set; }

        internal override List<string> ErrorMessages { get; set; }
        internal override bool IsValid()
        {
            if (OrderId == Guid.Empty)
            {
                ErrorMessages.Add("O guid não pode estar vazio");
            }
            return OrderId != Guid.Empty;
        }
    }
}
