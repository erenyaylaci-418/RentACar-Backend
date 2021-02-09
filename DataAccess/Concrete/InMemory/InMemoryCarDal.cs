using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ModelYear=2001,DailyPrice=100,Description="Bu araç SUV türü güçlü motorludur"},
                new Car{Id=2,BrandId=2,ModelYear=2019,DailyPrice=150,Description="Bu araç otonom sürüş keyfi yaşatır"},
                new Car{Id=3,BrandId=1,ModelYear=2011,DailyPrice=200,Description="Bu araç SUv türü güçlü motorludur Az yakar çok kaçar"},
                new Car{Id=4,BrandId=2,ModelYear=2015,DailyPrice=50,Description="Uygun fiyatlı şehir içi elektrikli"}

            }; 
        }






        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int ID)
        {
            Car result = _cars.SingleOrDefault(c => c.Id == ID);
            return result;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
