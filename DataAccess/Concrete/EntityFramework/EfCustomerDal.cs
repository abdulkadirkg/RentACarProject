using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarContext>, ICustomerDal
    {
        public List<Customer> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
