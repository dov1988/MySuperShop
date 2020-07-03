using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class PaymentController : Controller
    {
        public ActionResult PaymentData()
        {
            double totalPrice = 168764;
            return View(totalPrice);
        }
    }
}