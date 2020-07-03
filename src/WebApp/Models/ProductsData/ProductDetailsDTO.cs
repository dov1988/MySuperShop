using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using WebApp.Models.Reviews;

namespace WebApp.Models.ProductsData
{
    public class ProductDetailsDTO
    {
        public string Photo { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<string> Sizes { get; set; }
        public string Color { get; set; }
        public string Composition { get; set; }
        public string Description { get; set; }
        public List<IndexDTO> Reviews { get; set; }
        public ProductDetailsDTO()
        {
            Sizes = new List<string>();
            Reviews = new List<IndexDTO>();
        }
    }
}