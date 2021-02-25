using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandService _iBrandService;

        public BrandManager(IBrandService iBrandService)
        {
            _iBrandService = iBrandService;
        }

        public void Add(Brand brand)
        {
            _iBrandService.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _iBrandService.Delete(brand);
        }

        public List<Brand> GetAll()
        {
           return _iBrandService.GetAll();
        }

        public List<Brand> GetById(int id)
        {
            return _iBrandService.GetById(id);
        }

        public void Update(Brand brand)
        {
            _iBrandService.Update(brand);
        }
    }
}
