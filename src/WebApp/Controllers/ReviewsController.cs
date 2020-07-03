using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models.Reviews;

namespace WebApp.Controllers
{
    public class ReviewsController : Controller
    {
        public ActionResult Index()
        {
            ProductReviewDTO productReview = new ProductReviewDTO();
            productReview.Name = "Варежки 'Бабушка-рукодельница'";
            productReview.Number = "123456";
            IndexDTO reviews1 = new IndexDTO();
            reviews1.NameCustomer = "Василий Петров";
            reviews1.DateReview = new DateTime(2008, 02, 05);
            reviews1.TextReview = "Варежки прекрасные!";
            IndexDTO reviews2 = new IndexDTO();
            reviews2.NameCustomer = "Мария Ситникова";
            reviews2.DateReview = new DateTime(2008, 02, 06);
            reviews2.TextReview = "Говно ваши варежки!";
            IndexDTO reviews3 = new IndexDTO();
            reviews3.NameCustomer = "Ольга Иванова";
            reviews3.DateReview = new DateTime(2008, 02, 07);
            reviews3.TextReview = "На разок пойдут…";
            IndexDTO reviews4 = new IndexDTO();
            reviews4.NameCustomer = "Василий Муравьев";
            reviews4.DateReview = new DateTime(2008, 02, 05);
            reviews4.TextReview = "Моя бабушка лучше вяжет. Обращайтесь!";
            IndexDTO reviews5 = new IndexDTO();
            reviews5.NameCustomer = "Петр Кошкин";
            reviews5.DateReview = new DateTime(2008, 02, 05);
            reviews5.TextReview = "В -30 в них холодно. Отморозила руки!";
            IndexDTO reviews6 = new IndexDTO();
            reviews6.NameCustomer = "Алла Пугачева";
            reviews6.DateReview = new DateTime(2008, 02, 05);
            reviews6.TextReview = "На зимнюю рыбалку вообще отлично!";
            IndexDTO reviews7 = new IndexDTO();
            reviews7.NameCustomer = "Вася Пупкин";
            reviews7.DateReview = new DateTime(2008, 02, 05);
            reviews7.TextReview = "Варежки пришли поеденные молью!";
            productReview.Reviews.Add(reviews1);
            productReview.Reviews.Add(reviews2);
            productReview.Reviews.Add(reviews3);
            productReview.Reviews.Add(reviews4);
            productReview.Reviews.Add(reviews5);
            productReview.Reviews.Add(reviews6);
            productReview.Reviews.Add(reviews7);
            return View(productReview);
        }
        public ActionResult AddReview()
        {
            return View();
        }
    }
}