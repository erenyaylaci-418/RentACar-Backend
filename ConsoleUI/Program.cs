using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           CarManager carManager = new CarManager(new EfCarDal());
            //Car car1 = new Car { Id = 4, BrandId = 1,ColorId=2, ModelYear = 2001, DailyPrice = 100, Description = "Bu araç SUV türü güçlü motorludur" };
            // carManager.Add(car1);
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.BrandName + "//" + item.ColorName + "//" + item.ModelYear + "//" + item.DailyPrice);
            }
        }
    }
}
