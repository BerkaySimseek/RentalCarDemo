using System;
using System.Data;
using Business.Concrate;
using Business.Constants;
using DataAccess.Concrate.EntityFramework;
using Entities.Concrate;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental secondRental = new Rental
            {
                CarId = 1, CustomerId = 1, RentDate = new DateTime(2021,3,15), RentId = 3
            };

            rentalManager.Add(secondRental);
        }

    }
}
