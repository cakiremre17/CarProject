using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;


        public InMemoryCarDal()
        {
            //_cars = new List<Car>
            //{
            //    new Car {CarId= 1 , BrandId= 1 , ColorId=1 , DailyPrice = 1500 , CarName= "BMW Araba" , ModelYear = 2000},
            //    new Car {CarId= 2 , BrandId= 1 , ColorId=2 , DailyPrice = 2500 , CarName= "Merso Araba" , ModelYear = 2003},
            //    new Car {CarId= 3 , BrandId= 2 , ColorId=3 , DailyPrice = 4500 , CarName= "Reno Araba" , ModelYear = 2005},
            //    new Car {CarId= 4 , BrandId= 2 , ColorId=4 , DailyPrice = 7500 , CarName= "Honda Araba" , ModelYear = 2020},
            //    new Car {CarId= 5 , BrandId= 3 , ColorId=5 , DailyPrice = 8500 , CarName= "Ford Araba" , ModelYear = 2015},
            //};
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();

        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpDate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpDate.CarId = car.CarId;
       
            carToUpDate.ModelYear = car.ModelYear;
            carToUpDate.DailyPrice = car.DailyPrice;
            carToUpDate.CarName = car.CarName;
        }
    }
}
