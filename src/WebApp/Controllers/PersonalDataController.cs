using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models.PersonalData;

namespace WebApp.Controllers
{
    public class PersonalDataController : Controller
    {
        public ActionResult PersonalArea()
        {
            PersonalAreaDTO personalArea = new PersonalAreaDTO();
            personalArea.Photo = @"https://23.img.avito.st/640x480/4907230123.jpg";
            personalArea.FirstName = "Сергей";
            personalArea.MiddleName = "Борисович";
            personalArea.LastName = "Бурмистров";
            personalArea.Gender = "Мужской";
            personalArea.Birthday = new DateTime(1988, 04, 27);
            personalArea.Phone = "8-919-825-47-70";
            personalArea.Email = "bsb1988@gmail.com";
            return View(personalArea);
        }
        public ActionResult DataEditing()
        {
            PersonalAreaDTO personalArea = new PersonalAreaDTO();
            personalArea.Photo = @"https://23.img.avito.st/640x480/4907230123.jpg";
            personalArea.FirstName = "Сергей";
            personalArea.MiddleName = "Борисович";
            personalArea.LastName = "Бурмистров";
            personalArea.Gender = "Мужской";
            personalArea.Birthday = new DateTime(1988, 04, 27);
            personalArea.Phone = "8-919-825-47-70";
            personalArea.Email = "bsb1988@gmail.com";
            return View(personalArea);
        }

        public ActionResult DataStorage()
        {
            return View();
        }
    }
}