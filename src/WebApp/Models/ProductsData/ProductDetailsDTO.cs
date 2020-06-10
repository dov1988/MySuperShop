using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models.ProductsData
{
    public class ProductDetailsDTO
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}