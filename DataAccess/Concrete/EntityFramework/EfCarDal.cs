using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            if (entity.BrandName.Length < 2)
            {
                Console.WriteLine(entity.BrandName + " 2 karakterden daha uzun olmalıdır.");
                return;
            }

            if (entity.DailyPrice <= 0)
            {
                Console.WriteLine(entity.BrandName + " günlük fiyat 0 dan büyük olmak zorundadır!");
                return;
            }

            //IDisposable pattern implementation of c#
            using (CarContext context = new CarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (CarContext context = new CarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void DeleteAll<Car>()
        {
            using (CarContext context = new CarContext())
            {
                context.Database.ExecuteSqlCommand("delete from Car");
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarContext context = new CarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            using (CarContext context = new CarContext())
            {
                return context.Set<Car>().Where(c => c.BrandId == id).ToList();
            }
        }

        public List<Car> GetCarsByColorId(int id)
        {
            using (CarContext context = new CarContext())
            {
                return context.Set<Car>().Where(c => c.ColorId == id).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (CarContext context = new CarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
