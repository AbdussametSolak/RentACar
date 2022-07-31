using Core.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car: IEntity
    {
        public int CarId { get; set; } // PK
        public int BrandId { get; set; } // FK from brands
        public int ColorId { get; set; } // FK from colors
        public string CarName { get; set; }
        public DateOnly ModelYear { get; set; }
        public float DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
