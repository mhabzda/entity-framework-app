﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDatabase
{
    class Customer
    {
        [Key]
        public string CompanyName { get; set; }
        public string Description { get; set; }
    }
}
