using Core.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Brand: IEntity
    {
        public int BrandId { get; set; } // PK
        public string BrandName { get; set; }
    }
}
