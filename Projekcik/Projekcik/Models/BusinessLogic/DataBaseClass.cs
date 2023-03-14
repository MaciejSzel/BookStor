using Projekcik.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.Models.BusinessLogic
{
    public class DataBaseClass
    {
        #region Entities
        public BookStoreEntities BookStoreEntities { get; set; }
        #endregion
        public DataBaseClass(BookStoreEntities bookStoreEntities)
        {
            this.BookStoreEntities = bookStoreEntities;
        }
    }
}
