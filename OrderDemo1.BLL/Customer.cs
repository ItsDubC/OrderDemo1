﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo1.BLL
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer() {}

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
