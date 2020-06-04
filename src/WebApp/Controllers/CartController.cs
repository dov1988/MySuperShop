using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PagesCatalog()
        {
            return View();
        }

        public ActionResult ProductDetails()
        {
            return View();
        }

        public ActionResult HomePage()
        {
           return View();
        }
    }
}