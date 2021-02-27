using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _iUserDal;

        public UserManager(IUserDal iCustomerService)
        {
            _iUserDal = iCustomerService;
        }

        public void Add(User user)
        {
            _iUserDal.Add(user);
        }

        public void Delete(User user)
        {
            _iUserDal.Delete(user);
        }

        public List<User> GetAll()
        {
            return _iUserDal.GetAll();
        }

        public void Update(User user)
        {
            _iUserDal.Update(user);
        }
    }
}
