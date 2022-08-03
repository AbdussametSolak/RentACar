using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public void Add(Rental rental)
        {
            _rentalDal.Add(rental);
        }

        public void Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
        }

        public Rental Get(int rentalId)
        {
            return _rentalDal.Get(r=>r.RentalId==rentalId);
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public List<Rental> GetAllByCarId(int carId)
        {
            return _rentalDal.GetAll(r=>r.CarId==carId);
        }

        public List<Rental> GetAllByCustomerId(int customerId)
        {
            return _rentalDal.GetAll(r=>r.CustomerId==customerId);
        }

        public void Update(Rental rental)
        {
            _rentalDal.Update(rental);
        }
    }
}
