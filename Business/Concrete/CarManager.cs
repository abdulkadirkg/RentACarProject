using Business.Abstract;
using DataAccess.Abstract;
using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }
        public IResult Add(Car car)
        {
            _iCarDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _iCarDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult DeleteAll()
        {
            _iCarDal.DeleteAll();
            return new SuccessResult(Messages.CarDeleted);
        }

        //public void DeleteAll<Car>()
        //{
        //    _iCarDal.DeleteAll<Car>;
        //}

        public IDataResult<List<Car>> GetAll()
        {
            //return _iCarDal.GetAll();

            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(),"Araçlar Listelendi");
        }

        public IDataResult<List<Car>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetCarsByBrandId(id));
        }

        public IDataResult<List<Car>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetCarsByColorId(id));
        }

        public IDataResult<List<Car>> GetById(int id)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(p => p.Id == id));
        }

        public IDataResult<List<CarDetailDTO>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDTO>>(_iCarDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _iCarDal.Update(car);
            return new SuccessResult("Güncelleme başarılı!");
        }
    }
}
