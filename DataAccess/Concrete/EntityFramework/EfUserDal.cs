using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarContext>, IUserDal
    {
        public List<User> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
