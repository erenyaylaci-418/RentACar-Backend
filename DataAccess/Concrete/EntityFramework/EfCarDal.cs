using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : IEntityRepositoryBase<Car, CarSystemDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarSystemDBContext context = new CarSystemDBContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             select new CarDetailDto
                             {
                                 CarId = car.Id,BrandName = brand.BrandName ,ColorName = color.ColorName,ModelYear = car.ModelYear,DailyPrice = car.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
