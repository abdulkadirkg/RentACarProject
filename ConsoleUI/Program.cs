using Business.Concrete;
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
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Car car = new Car {
                Id = 1,
                BrandId = 1,
                BrandName = "BMW",
                ColorId = 3,
                DailyPrice = 45.000,
                Description = "BMW 7.40 LD Long Kasa",
                ModelYear = 2021
            };
            Car car2 = new Car
            {
                Id = 2,
                BrandId = 2,
                ColorId = 2,
                BrandName = "Mercedes-Benz",
                DailyPrice = 65.000,
                Description = "Mercedes-Benz C200d Diesel 150 HP",
                ModelYear = 2021
            };
            Car car3 = new Car
            {
                Id = 3,
                BrandId = 2,
                ColorId = 5,
                BrandName = "Audi",
                DailyPrice = 55.000,
                Description = "Audi A7 250 HP",
                ModelYear = 2020
            };
            Console.WriteLine("---ADD---------------------------------------");
            carManager.Add(car);
            carManager.Add(car2);
            carManager.Add(car3);
            Console.WriteLine("---GET---------------------------------------");
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.BrandName);
            }
            Console.WriteLine("---UPDATE------------------------------------");
            car2.BrandName = "DEGISEN MARKA ADI";
            carManager.Update(car2);
            Console.WriteLine("---GET---------------------------------------");
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.BrandName);
            }
            Console.WriteLine("---DELETE------------------------------------");
            carManager.Delete(car2);
            Console.WriteLine("---GET---------------------------------------");
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.BrandName);
            }
            Console.WriteLine("---GETBYID-----------------------------------");
            var get = carManager.GetById(1)[0];
            Console.WriteLine(get.BrandName);
        }
    }
}
