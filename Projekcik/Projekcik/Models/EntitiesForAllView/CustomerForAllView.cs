using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.Models.EntitiesForAllView
{
    public class CustomerForAllView
    {
        public int CustomerId { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string StreetName { get; set; }
        public string Numer { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Adress_Stat { get; set; }
        public int adres_id { get; set; }
        public int country_id { get; set; }
        public int stat_id { get; set; }



    }
}
