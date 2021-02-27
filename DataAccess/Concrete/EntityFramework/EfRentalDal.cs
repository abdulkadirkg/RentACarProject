﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        public List<Rental> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rental> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
