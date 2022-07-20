using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        //List<Car> GetCarsByColorId(int colorId);
        //List<Car> GetCarsByBrandId(int brandId);

        List<CarDetailsDto> GetCarsDetails();
        Car GetCarsById(int carId);
        List<Car> GetAll();
        void Insert(Car car);
        void Update(Car car);
        void Delete(Car car);

        IResult Add(Car car);

    }
}
