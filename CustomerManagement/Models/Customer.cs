﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManagement.Models
{
    public class Customer
    {
        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public int Age
        {
            get; set;
        }

        public string ShoppingCategory
        {
            get; set;
        }

        public int RegistrationNumber
        {
            get; set;
        }
    }
}