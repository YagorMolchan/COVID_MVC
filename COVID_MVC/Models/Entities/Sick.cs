using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COVID_MVC.Models.Entities
{
    public class Sick
    {
        public int Id { get; set; }

        public Area Area { get; set; }

        public Town Town { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Plea { get; set; }

        public string PaymentMethod { get; set; }


    }

   
}