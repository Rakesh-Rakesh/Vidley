﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidley.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedtoNewLater { get; set; }
    }
}