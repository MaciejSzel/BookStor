using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.Models.EntitiesForAllView
{
    public class OrderForAllView
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string StreetName { get; set; }
        public string Numer { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int? CustomerId { get; set; }

        public string Title { get; set; }
        public string Language_name { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string Author { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cena { get; set; }
        public DateTime? OrderDate { get; set; }
        public int ShippingMethodId { get; set; }
        public int ordId { get; set; }

    }
}
