using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }


            Console.WriteLine("-----------------Add-------------------");
            carManager.Add(new Car { Id = 6, BrandId = 2, ColorId = 4, DailyPrice = 60000, ModelYear = "2015", Description = "Fiat Doblo" });

            Console.WriteLine("Yeni araba eklenmiştir.");
            Console.WriteLine("---------------------------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.ReadLine();
        }
    }
}
