using Core.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rental: IEntity
    {
        public int RentalId { get; set; } // PK
        public int CustomerId { get; set; } // FK from customers
        public int CarId { get; set; } // FK from cars
        public string RentalNote { get; set; }
        public DateOnly RentalDate { get; set; }
        public DateOnly RentalReturnDate { get; set; }
        public int PaymentMethodId { get; set; } // FK from paymentMethods 
    }
}
