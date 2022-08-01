using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        public List<Car> GetAll();
        public List<Car> GetAllByBrandId(int brandId);
        public List<Car> GetAllByColorId(int colorId);
        public Car Get(int carId);
    }
}
