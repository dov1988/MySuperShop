﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class ProductsDataController : Controller
    {
        public ActionResult ProductsCatalog()
        {
            return View();
        }
        public ActionResult PageCatalog()
        {
            return View();
        }

        public ActionResult ProductDetails()
        {
            return View();
        }
    }
}