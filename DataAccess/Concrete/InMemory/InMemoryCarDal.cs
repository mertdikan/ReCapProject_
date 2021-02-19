using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
    {
        _cars = new List<Car> {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear="2017",DailyPrice=57000,Descriptions="Audi A3" },
                new Car{CarId=1,BrandId=2,ColorId=2,ModelYear="2015",DailyPrice=37000,Descriptions="Ford focus" },
                new Car{CarId=1,BrandId=2,ColorId=3,ModelYear="2017",DailyPrice=69000,Descriptions="Audi A6" },
                new Car{CarId=1,BrandId=3,ColorId=3,ModelYear="2016",DailyPrice=158000,Descriptions="Mercedes Amg" },
                new Car{CarId=1,BrandId=3,ColorId=5,ModelYear="2016",DailyPrice=58000,Descriptions ="Audi A4" }
            };
    }
    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Delete(Car car)
    {
        //Linq
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

        public List<Car> GetById(int id)
    {
        return _cars.Where(c => c.CarId == id).ToList();
    }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
    {
        Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        carToUpdate.CarId = car.CarId;
        carToUpdate.ColorId = car.ColorId;
        carToUpdate.BrandId = car.BrandId;
        carToUpdate.DailyPrice = car.DailyPrice;
        carToUpdate.Descriptions = car.Descriptions;
        carToUpdate.ModelYear = car.ModelYear;

    }
}
}
