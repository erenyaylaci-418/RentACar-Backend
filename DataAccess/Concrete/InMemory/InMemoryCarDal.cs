using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ID=1,BrandID=1,ModelYear=2001,DailyPrice=100,Description="Bu araç SUV türü güçlü motorludur"},
                new Car{ID=2,BrandID=2,ModelYear=2019,DailyPrice=150,Description="Bu araç otonom sürüş keyfi yaşatır"},
                new Car{ID=3,BrandID=1,ModelYear=2011,DailyPrice=200,Description="Bu araç SUv türü güçlü motorludur Az yakar çok kaçar"},
                new Car{ID=4,BrandID=2,ModelYear=2015,DailyPrice=50,Description="Uygun fiyatlı şehir içi elektrikli"}

            }; 
        }






        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.ID == car.ID);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int ID)
        {
            Car result = _cars.SingleOrDefault(c => c.ID == ID);
            return result;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.ID == car.ID);
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
