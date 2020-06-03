using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class PersonalDataController : Controller
    {
        public ActionResult PersonalArea()
        {
            return View();
        }
        public ActionResult DataEditing()
        {
            return View();
        }

        public ActionResult DataStorage()
        {
            return View();
        }

        public ActionResult HomePage()
        {
           return View();
        }
    }
}