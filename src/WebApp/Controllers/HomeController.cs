using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Entry()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult PasswordRecovery()
        {
            return View();
        }

        public ActionResult HomePage()
        {
           return View();
        }
    }
}