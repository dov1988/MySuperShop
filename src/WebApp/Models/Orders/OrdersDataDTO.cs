using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models.OrdersData
{
    public class OrdersDataDTO
    {
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}