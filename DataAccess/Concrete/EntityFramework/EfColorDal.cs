using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarContext>, IColorDal
    {
        public List<Color> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
