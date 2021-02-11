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
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            CostumerManager costumerManager = new CostumerManager(new EfCostumerDal());
            // DetailsTest(carManager);
            User user1 = new User()
            {
                FirstName = "Eren",
                LastName = "Yaylacı",
                Email ="erenyaylacitr@gmail.com",
                Password ="1453220"
                
            };
            User user2 = new User()
            {
                FirstName = "Taha",
                LastName = "Yaylacı",
                Email = "tahayaylaci@gmail.com",
                Password = "1453220"

            };
            /*
            Color color1 = new Color { ColorName = "Yellow" };
            Color color2 = new Color {ColorName = "Grey" };
            Color color3 = new Color { ColorName = "White" };
            Color color4 = new Color {ColorName = "Blue" };
            Color color5 = new Color {ColorName = "Black" };
            
            
            colorManager.Add(color2);
            colorManager.Add(color3);
            colorManager.Add(color4);
            colorManager.Add(color5);
           /*
            Brand brand1 = new Brand { BrandName = "Mercedes" };
            Brand brand2 = new Brand { BrandName = "Opel" };
            Brand brand3 = new Brand { BrandName = "Suziki" };


            brandManager.Add(brand1);
            brandManager.Add(brand2);
            brandManager.Add(brand3);
            */
            
            Car car1 = new Car { BrandId = 1,ColorId = 1, ModelYear = 2001, DailyPrice = 100, Description = "Bu araç SUV türü güçlü motorludur" };
            Car car2 = new Car { BrandId = 2, ColorId = 1, ModelYear = 2019, DailyPrice = 150, Description = "Bu araç otonom sürüş keyfi yaşatır" };
            Car car3 = new Car { BrandId = 1, ColorId = 1,ModelYear = 2011, DailyPrice = 200, Description = "Bu araç SUv türü güçlü motorludur Az yakar çok kaçar" };
            Car car4 = new Car { BrandId = 2, ColorId = 1, ModelYear = 2015, DailyPrice = 50, Description = "Uygun fiyatlı şehir içi elektrikli" };

            carManager.Add(car1);
            carManager.Add(car2);
            carManager.Add(car3);
            carManager.Add(car4);
           





        }
    }
}
