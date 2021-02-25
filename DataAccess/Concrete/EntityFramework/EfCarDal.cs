using DataAccess.Abstract;
using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>,ICarDal
    {
        public List<CarDetailDTO> GetCarDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from cr in context.Car
                             join clr in context.Colors
                             on cr.ColorId equals clr.Id
                             join brnd in context.Brands
                             on cr.BrandId equals brnd.Id
                             select new CarDetailDTO
                             {
                                 CarName = cr.BrandName,
                                 BrandName = brnd.BrandName,
                                 ColorName = clr.ColorName,
                                 DailyPrice = cr.DailyPrice
                             };
                return result.ToList();
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
    }
}
