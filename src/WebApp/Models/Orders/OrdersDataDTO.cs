using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using WebApp.Models.Orders;

namespace WebApp.Models.Orders
{
    public class OrdersDataDTO
    {
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OrderStatus { get; set; }
        public List<OrderProductDTO> OrdersProducts { get; set; }
        public OrdersDataDTO()
        {
            this.OrdersProducts = new List<OrderProductDTO>();
        }
    }
}