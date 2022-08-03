using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        void Add(Rental rental);
        void Update(Rental rental);
        void Delete(Rental rental);
        public List<Rental> GetAll();
        public Rental Get(int rentalId);
        public List<Rental> GetAllByCustomerId(int customerId);
        public List<Rental> GetAllByCarId(int carId);
    }
}
