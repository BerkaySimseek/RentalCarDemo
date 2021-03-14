using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentalCarContext>, ICustomerDal
    {
        public List<CustomerDetailDTO> GetCustomerDetailDtos()
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from c in context.Customers
                    join u in context.Users on c.UserId equals u.UserId
                    select new CustomerDetailDTO
                    {
                        CompanyName = c.CompanyName, FirstName = u.FirstName, LastName = u.LastName
                    };
                return result.ToList();
            }
        }
    }
}
