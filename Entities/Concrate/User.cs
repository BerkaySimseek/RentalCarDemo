﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrate
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
    }
}
