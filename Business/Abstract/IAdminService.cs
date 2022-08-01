using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdminService
    {
        void Add(Admin admin);
        void Update(Admin admin);
        void Delete(Admin admin);
        public List<Admin> GetAll();
        public Admin Get(int adminId);
    }
}
