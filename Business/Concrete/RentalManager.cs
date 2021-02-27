using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _iRentalDal;

        public RentalManager(IRentalDal iRentalService)
        {
            _iRentalDal = iRentalService;
        }

        public void Add(Rental brand)
        {
            _iRentalDal.Add(brand);
        }

        public void Delete(Rental brand)
        {
            _iRentalDal.Delete(brand);
        }

        public List<Rental> GetAll()
        {
            return _iRentalDal.GetAll();
        }

        public void Update(Rental brand)
        {
            _iRentalDal.Update(brand);
        }
    }
}
