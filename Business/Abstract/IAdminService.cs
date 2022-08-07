using Core.Utilities.Results;
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
        public IResult Add(Admin admin);
        public IResult Update(Admin admin);
        public IResult Delete(Admin admin);
        IDataResult<List<Admin>>GetAll();
        IDataResult<Admin> Get(int adminId);
    }
}
