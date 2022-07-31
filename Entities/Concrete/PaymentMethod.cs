using Core.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PaymentMethod: IEntity
    {
        public int PaymentMethodId { get; set; } // PK
        public string PaymentMethodName { get; set; }

    }
}
