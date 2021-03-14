using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;

namespace Entities.Concrate
{
    public class Rental : IEntity
    {
        [Key]
        public int RentId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int RentDate { get; set; }
        public int ReturnDate { get; set; }
    }
}
