using Projekcik.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.Models.BusinessLogic
{
    public class BooksValue:DataBaseClass
    {
        public BooksValue(BookStoreEntities bookStoreEntities)
            :base(bookStoreEntities)
        {

        }

        #region Funkcje biznesowe
        public decimal? WartoscKsiazek(DateTime dataOd, DateTime dataDo)
        {
            return
                (
                from books in BookStoreEntities.book
                where
                books.publication_date >= dataOd &&
                books.publication_date <= dataDo
                
                select books.Cena
                ).Sum();
        }
        #endregion
    }
}
