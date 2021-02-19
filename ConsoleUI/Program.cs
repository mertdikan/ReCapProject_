using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //InMemoryCarDal();

            //CarManagerTest();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { CustomerId = 1, CarId = 1, RentDate = DateTime.Now });
            rentalManager.Add(new Rental { CustomerId = 1, CarId = 1, RentDate = DateTime.Now });
            rentalManager.Add(new Rental { CustomerId = 2, CarId = 1, RentDate = DateTime.Now });

            foreach (var rental in rentalManager.GetRentalDetailsDto(1).Data)
            {
                Console.WriteLine("Araba adı = " + rental.CarName + ",   Müşteri adı = " + rental.CustomerName +
                    ",  Arabayı kiraladığı gün = " + rental.RentDate + ",  Kullanıcı adı = " + rental.UserName);
            }





        }


       




        //private static void CarManagerTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetCarDetails())
        //    {
        //        Console.WriteLine(car.Description);
        //    }

        //    carManager.Add(new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 15000, Descriptions = "Mercedes A150", ModelYear = "1997", CarName = "Mercedes" });
        //    carManager.Add(new Car { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 20000, Descriptions = "Suprise Car", ModelYear = "2005", CarName = "AlfaRomeo" });
        //    Console.ReadLine();
        //}



        //private static void InMemoryCarDal()
        //{
        //    CarManager carManager = new CarManager(new InMemoryCarDal());

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }


        //    Console.WriteLine("-----------------Add-------------------");
        //    carManager.Add(new Car { Id = 6, BrandId = 2, ColorId = 4, DailyPrice = 60000, ModelYear = "2015", Description = "Fiat Doblo" });

        //    Console.WriteLine("Yeni araba eklenmiştir.");
        //    Console.WriteLine("---------------------------------------");
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}
    }
}
