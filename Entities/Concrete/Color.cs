using Core.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Color: IEntity
    {
        public int ColorId { get; set; } // PK
        public string ColorName { get; set; }
    }
}
