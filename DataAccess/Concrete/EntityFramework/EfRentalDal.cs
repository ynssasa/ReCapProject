using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public bool CheckRentalReturn(DateTime? rental)
        {
            if(rental==null)
            {
                return true;
            }

            return false;
        }

        public List<RentalDetailsDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                             join b in context.Brands
                             on r.Id equals b.Id
                             join u in context.Users
                             on r.CustomerId equals u.Id
                             select new RentalDetailsDto { Id=r.Id,BrandName=b.BrandName,CustomerName=u.LastName+" "+u.FirstName
                             ,RentDate=r.RentDate,ReturnDate=r.ReturnDate};

                return result.ToList();
            }
        }
    }
}
