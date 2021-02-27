using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.InMemory2;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProgramCS();
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User() { 
                FirstName = "Abdulkadir",
                LastName = "KG",
                Email = "abdulkadir@abdulkadir.com",
                Password = "123456"
            };
            userManager.Add(user);

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental() { 
                CarId = 2,
                CustomerId = 1,
                RentDate = DateTime.Now
            };
            rentalManager.Add(rental);


        }

        private static void ProgramCS()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                BrandId = 1,
                BrandName = "BMW",
                ColorId = 3,
                DailyPrice = 0,
                Description = "BMW 7.40 LD Long Kasa",
                ModelYear = 2021
            };
            Car car2 = new Car
            {
                BrandId = 3,
                ColorId = 2,
                BrandName = "Mercedes-Benz",
                DailyPrice = 65000,
                Description = "Mercedes-Benz C200d Diesel 150 HP",
                ModelYear = 2021
            };
            Car car3 = new Car
            {
                BrandId = 2,
                ColorId = 5,
                BrandName = "Audi",
                DailyPrice = 55000,
                Description = "Audi A7 250 HP",
                ModelYear = 2020
            };
            //
            Console.WriteLine("---ADD---------------------------------------");
            carManager.Add(car);
            carManager.Add(car2);
            carManager.Add(car3);
            Console.WriteLine("---GET---------------------------------------");
            foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine(c.BrandName);
            }
            Console.WriteLine("---UPDATE------------------------------------");
            car2.BrandName = "DEGISEN MARKA ADI";
            carManager.Update(car2);
            Console.WriteLine("---GET---------------------------------------");
            foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine(c.BrandName);
            }
            Console.WriteLine("---DELETE------------------------------------");
            //carManager.Delete(car2);
            Console.WriteLine("---GET---------------------------------------");
            foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine(c.BrandName);
            }
            Console.WriteLine("---GETBYID-----------------------------------");
            //var get = carManager.GetById(22);
            //Console.WriteLine(get.BrandName);
            Console.WriteLine("---GETBYCOLORID------------------------------");
            var getCar = carManager.GetByBrandId(22).Data;
            foreach (var c in getCar)
            {
                Console.WriteLine(c.BrandName + c.BrandId + "<->" + c.DailyPrice);
            }

            //carManager.DeleteAll();

            var details = carManager.GetCarDetails().Data;
            foreach (var detail in details)
            {
                Console.WriteLine(detail.BrandName + " - " + detail.CarName + " - " + detail.ColorName);
            }
        }
    }
}
