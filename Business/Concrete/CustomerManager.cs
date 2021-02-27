using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _iCustomerDal;

        public CustomerManager(ICustomerDal iCustomerService)
        {
            _iCustomerDal = iCustomerService;
        }

        public void Add(Customer brand)
        {
            _iCustomerDal.Add(brand);
        }

        public void Delete(Customer brand)
        {
            _iCustomerDal.Delete(brand);
        }

        public List<Customer> GetAll()
        {
            return _iCustomerDal.GetAll();
        }

        public void Update(Customer brand)
        {
            _iCustomerDal.Update(brand);
        }
    }
}
