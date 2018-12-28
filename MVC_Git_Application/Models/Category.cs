﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Git_Application.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}