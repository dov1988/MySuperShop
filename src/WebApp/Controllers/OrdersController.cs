using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models.Orders;

namespace WebApp.Controllers
{
    public class OrdersController : Controller
    {
        public ActionResult OrdersHistory()
        {
            OrdersDataDTO order1 = new OrdersDataDTO();
            order1.OrderDate = new DateTime(2008, 5, 1);
            order1.OrderNumber = "1";
            order1.DeliveryDate = new DateTime(2008, 5, 2);
            order1.OrderStatus = "Получен";
            OrderProductDTO orderProduct1 = new OrderProductDTO();
            orderProduct1.ProductNumber = "1111";
            orderProduct1.Name = "Сало";
            orderProduct1.Quantity = 1;
            orderProduct1.Price = 100;
            OrderProductDTO orderProduct2 = new OrderProductDTO();
            orderProduct2.ProductNumber = "2222";
            orderProduct2.Name = "Мыло";
            orderProduct2.Quantity = 2;
            orderProduct2.Price = 200;
            OrderProductDTO orderProduct3 = new OrderProductDTO();
            orderProduct3.ProductNumber = "3333";
            orderProduct3.Name = "Рыло";
            orderProduct3.Quantity = 3;
            orderProduct3.Price = 300;
            order1.OrdersProducts.Add(orderProduct1);
            order1.OrdersProducts.Add(orderProduct2);
            order1.OrdersProducts.Add(orderProduct3);
            OrdersDataDTO order2 = new OrdersDataDTO();
            order2.OrderDate = new DateTime(2008, 6, 12);
            order2.OrderNumber = "2";
            order2.DeliveryDate = new DateTime(2008, 6, 13);
            order2.OrderStatus = "Получен";
            OrderProductDTO orderProduct4 = new OrderProductDTO();
            orderProduct4.ProductNumber = "4444";
            orderProduct4.Name = "Тело";
            orderProduct4.Quantity = 4;
            orderProduct4.Price = 400;
            OrderProductDTO orderProduct5 = new OrderProductDTO();
            orderProduct5.ProductNumber = "5555";
            orderProduct5.Name = "Шило";
            orderProduct5.Quantity = 5;
            orderProduct5.Price = 500;
            OrderProductDTO orderProduct6 = new OrderProductDTO();
            orderProduct6.ProductNumber = "6666";
            orderProduct6.Name = "Поло";
            orderProduct6.Quantity = 6;
            orderProduct6.Price = 600;
            order2.OrdersProducts.Add(orderProduct4);
            order2.OrdersProducts.Add(orderProduct5);
            order2.OrdersProducts.Add(orderProduct6);
            OrdersDataDTO order3 = new OrdersDataDTO();
            order3.OrderDate = new DateTime(2008, 7, 21);
            order3.OrderNumber = "3";
            order3.DeliveryDate = new DateTime(2008, 7, 22);
            order3.OrderStatus = "Получен";
            OrderProductDTO orderProduct7 = new OrderProductDTO();
            orderProduct7.ProductNumber = "7777";
            orderProduct7.Name = "Жало";
            orderProduct7.Quantity = 7;
            orderProduct7.Price = 700;
            OrderProductDTO orderProduct8 = new OrderProductDTO();
            orderProduct8.ProductNumber = "8888";
            orderProduct8.Name = "Соло";
            orderProduct8.Quantity = 8;
            orderProduct8.Price = 800;
            OrderProductDTO orderProduct9 = new OrderProductDTO();
            orderProduct9.ProductNumber = "9999";
            orderProduct9.Name = "Дело";
            orderProduct9.Quantity = 9;
            orderProduct9.Price = 900;
            order3.OrdersProducts.Add(orderProduct7);
            order3.OrdersProducts.Add(orderProduct8);
            order3.OrdersProducts.Add(orderProduct9);
            List<OrdersDataDTO> orders = new List<OrdersDataDTO>();
            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);
            return View(orders);
        }
        public ActionResult OrdersCurrent()
        {
            OrdersDataDTO order1 = new OrdersDataDTO();
            order1.OrderDate = new DateTime(2008, 5, 1);
            order1.OrderNumber = "1";
            order1.DeliveryDate = new DateTime(2008, 5, 2);
            order1.OrderStatus = "В сборке";
            OrderProductDTO orderProduct1 = new OrderProductDTO();
            orderProduct1.ProductNumber = "1111";
            orderProduct1.Name = "Рубашка";
            orderProduct1.Quantity = 1;
            orderProduct1.Price = 100;
            OrderProductDTO orderProduct2 = new OrderProductDTO();
            orderProduct2.ProductNumber = "2222";
            orderProduct2.Name = "Куртка";
            orderProduct2.Quantity = 2;
            orderProduct2.Price = 200;
            OrderProductDTO orderProduct3 = new OrderProductDTO();
            orderProduct3.ProductNumber = "3333";
            orderProduct3.Name = "Свитер";
            orderProduct3.Quantity = 3;
            orderProduct3.Price = 300;
            order1.OrdersProducts.Add(orderProduct1);
            order1.OrdersProducts.Add(orderProduct2);
            order1.OrdersProducts.Add(orderProduct3);
            OrdersDataDTO order2 = new OrdersDataDTO();
            order2.OrderDate = new DateTime(2008, 6, 12);
            order2.OrderNumber = "2";
            order2.DeliveryDate = new DateTime(2008, 6, 13);
            order2.OrderStatus = "В пути";
            OrderProductDTO orderProduct4 = new OrderProductDTO();
            orderProduct4.ProductNumber = "4444";
            orderProduct4.Name = "Пальто";
            orderProduct4.Quantity = 4;
            orderProduct4.Price = 400;
            OrderProductDTO orderProduct5 = new OrderProductDTO();
            orderProduct5.ProductNumber = "5555";
            orderProduct5.Name = "Валенки";
            orderProduct5.Quantity = 5;
            orderProduct5.Price = 500;
            OrderProductDTO orderProduct6 = new OrderProductDTO();
            orderProduct6.ProductNumber = "6666";
            orderProduct6.Name = "Платок";
            orderProduct6.Quantity = 6;
            orderProduct6.Price = 600;
            order2.OrdersProducts.Add(orderProduct4);
            order2.OrdersProducts.Add(orderProduct5);
            order2.OrdersProducts.Add(orderProduct6);
            OrdersDataDTO order3 = new OrdersDataDTO();
            order3.OrderDate = new DateTime(2008, 7, 21);
            order3.OrderNumber = "3";
            order3.DeliveryDate = new DateTime(2008, 7, 22);
            order3.OrderStatus = "В пути";
            OrderProductDTO orderProduct7 = new OrderProductDTO();
            orderProduct7.ProductNumber = "7777";
            orderProduct7.Name = "Туалетная бумага";
            orderProduct7.Quantity = 7;
            orderProduct7.Price = 700;
            OrderProductDTO orderProduct8 = new OrderProductDTO();
            orderProduct8.ProductNumber = "8888";
            orderProduct8.Name = "Книга";
            orderProduct8.Quantity = 8;
            orderProduct8.Price = 800;
            OrderProductDTO orderProduct9 = new OrderProductDTO();
            orderProduct9.ProductNumber = "9999";
            orderProduct9.Name = "Гречка";
            orderProduct9.Quantity = 9;
            orderProduct9.Price = 900;
            order3.OrdersProducts.Add(orderProduct7);
            order3.OrdersProducts.Add(orderProduct8);
            order3.OrdersProducts.Add(orderProduct9);
            List<OrdersDataDTO> orders = new List<OrdersDataDTO>();
            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);
            return View(orders);
        }

        public ActionResult OrderRegistration()
        {
            OrderRegistrationDTO orderRegistration = new OrderRegistrationDTO();
            orderRegistration.OrderNumber = "11223344";
            orderRegistration.PaymentType = "Банковская карта";
            orderRegistration.TotalPrice = 23415;
            return View(orderRegistration);
        }
    }
}