using Core.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Admin: IEntity
    {
        public int AdminId { get; set; } // PK
        public int UserId { get; set; } // FK from users
        public bool AdminStatu { get; set; }
    }
}
