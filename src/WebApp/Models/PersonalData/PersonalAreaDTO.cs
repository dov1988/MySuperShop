using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models.OrdersData
{
    public class PersonalAreaDTO
    {
        public string Photo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}