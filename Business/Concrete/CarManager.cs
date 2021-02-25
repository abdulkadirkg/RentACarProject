using Business.Abstract;
using DataAccess.Abstract;
using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }
        public void Add(Car car)
        {
            _iCarDal.Add(car);
        }

        public void Delete(Car car)
        {
            _iCarDal.Delete(car);
        }

        public void DeleteAll<Car>()
        {
            _iCarDal.DeleteAll<Car>();
        }

        //public void DeleteAll<Car>()
        //{
        //    _iCarDal.DeleteAll<Car>;
        //}

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public List<Car> GetByBrandId(int id)
        {
            return _iCarDal.GetCarsByBrandId(id);
        }

        public List<Car> GetByColorId(int id)
        {
            return _iCarDal.GetCarsByColorId(id);
        }

        public List<Car> GetById(int id)
        {
            return _iCarDal.GetAll(p => p.Id == id);
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            return _iCarDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _iCarDal.Update(car);
        }
    }
}
