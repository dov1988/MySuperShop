using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models.Reviews
{
    public class ProductReviewDTO
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public List<IndexDTO> Reviews { get; set; }
        public ProductReviewDTO()
        {
            Reviews = new List<IndexDTO>();
        }
    }
}