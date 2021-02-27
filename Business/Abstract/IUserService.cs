using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        void Add(User brand);
        void Update(User brand);
        void Delete(User brand);
    }
}
