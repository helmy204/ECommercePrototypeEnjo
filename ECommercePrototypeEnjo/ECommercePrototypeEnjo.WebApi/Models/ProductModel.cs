﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommercePrototypeEnjo.WebApi.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public double Price { get; set; }
    }
}