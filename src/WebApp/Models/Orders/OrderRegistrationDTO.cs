using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models.Orders
{
    public class OrderRegistrationDTO
    {
        public string OrderNumber { get; set; }
        public string PaymentType { get; set; }
        public double TotalPrice { get; set; }
    }
}