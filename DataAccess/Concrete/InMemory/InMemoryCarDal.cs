using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear="2017",DailyPrice=57000,Description="Audi A3" },
                new Car{Id=1,BrandId=2,ColorId=2,ModelYear="2015",DailyPrice=37000,Description="Ford focus" },
                new Car{Id=1,BrandId=2,ColorId=3,ModelYear="2017",DailyPrice=69000,Description="Audi A6" },
                new Car{Id=1,BrandId=3,ColorId=3,ModelYear="2016",DailyPrice=158000,Description="Mercedes Amg" },
                new Car{Id=1,BrandId=3,ColorId=5,ModelYear="2016",DailyPrice=58000,Description="Audi A4" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Linq
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id== car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
