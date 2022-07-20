using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.DTOs;
using Core.Utilities.Results;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Insert(Car car)
        {




            if (car.DailyPrice > 0 && car.CarName.Length >= 2)
            {
               _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Couldn't add to db");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        }

        public Car GetCarsById(int carId)
        {
            return _carDal.Get(p => p.CarId == carId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<CarDetailsDto> GetCarsDetails()
        {
            return _carDal.GetCarDetails();
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);

            
            return new Result(true , "Araba eklendi");
        }
    }

}