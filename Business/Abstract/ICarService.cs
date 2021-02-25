using Core.Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetById(int id);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetByBrandId(int id);
        List<Car> GetByColorId(int id);
        void DeleteAll<Car>();
        List<CarDetailDTO> GetCarDetails();
    }
}
