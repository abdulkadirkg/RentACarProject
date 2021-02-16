using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car = new List<Car>();

        public void Add(Car car)
        {
            Console.WriteLine("InMemoryCarDal ile eklendi ->>" + car.BrandName);
            car.DBDesc = "In Memory 1'den Eklendi";
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Console.WriteLine("InMemoryCarDal ile silindi");
            _car.Remove(_car.SingleOrDefault(c => c.Id == car.Id));
        }

        public List<Car> GetAll()
        {
            Console.WriteLine("InMemoryCarDal ile getirildi");
            return _car;
        }

        public void Update(Car car)
        {
            Console.WriteLine("InMemoryCarDal ile güncellendi");
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            //carToUpdate.Id = car.Id;
            //carToUpdate.BrandId = car.BrandId;
            //carToUpdate.ColorId = car.ColorId;
            //carToUpdate.DailyPrice = car.DailyPrice;
            //carToUpdate.Description = car.Description;
            //carToUpdate.ModelYear = car.ModelYear;
            carToUpdate = car;
        }
        public List<Car> GetById(int id)
        {
            Console.WriteLine("InMemoryCarDal ile ID'ye göre getirildi");
            return _car.Where(c => c.Id == id).ToList();
        }
    }
}
