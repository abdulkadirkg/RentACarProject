using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarContext>, IBrandDal
    {
        public List<Brand> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
