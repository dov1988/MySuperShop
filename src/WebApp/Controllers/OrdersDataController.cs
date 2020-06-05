using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class OrdersDataController : Controller
    {
        public ActionResult OrdersHistory()
        {
            return View();
        }
        public ActionResult OrdersCurrent()
        {
            return View();
        }

        public ActionResult OrderRegistration()
        {
            return View();
        }
    }
}