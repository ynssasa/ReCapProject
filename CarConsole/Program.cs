using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace CarConsole
{
    class Program
    {
         static void Main(string[] args)
          {
            //CarTest();

               RentalManager rentalManager = new RentalManager(new EfRentalDal());
             string message= rentalManager.Add(new Rental { CarId = 1,CustomerId=1,RentDate=DateTime.Now}).Message;

            Console.WriteLine(message);
            
             
        }

        private static void CarTest()
          {
              CarManager carManager = new CarManager(new EfCarDal());

              foreach (var car in carManager.GetAll().Data)
              {
                  Console.WriteLine(car.Description);
              }
          }



        

    }

   
}
