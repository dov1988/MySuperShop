using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models.Reviews
{
    public class IndexDTO
    {
        public DateTime DateReview { get; set; }
        public string NameCustomer  { get; set; }
        public string TextReview { get; set; }
    }
}