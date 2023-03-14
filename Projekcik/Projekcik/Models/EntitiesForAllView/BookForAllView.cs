using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.Models.Entities.EntitiesForAllView
{
    public class BookForAllView
    {
        public int BookId { get; set; }
        
        public string Title { get; set; } // nazwa ksiazki
        
        public string Language_code { get; set; }
       
        public string Language_name { get; set; }
        public int? Pages{ get; set; }
        public DateTime? PublicationDate { get; set; }
        public string PublisherName  { get; set; }
        public string Author { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cena { get; set; }

    }
}
