using Projekcik.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.Models.BusinessLogic
{
    public class CustomerOrdersValue:DataBaseClass
    {
        public CustomerOrdersValue(BookStoreEntities bookStoreEntities) : base(bookStoreEntities)
        {
        }
        #region Funkcje biznesowe
        public decimal? WartoscZamowienKlienta(int CustomerId, DateTime dataOd, DateTime dataDo)
        {
            return
                (
                from order in BookStoreEntities.order_line
                where order.cust_order.customer_id == CustomerId &&
                order.cust_order.order_date >= dataOd &&
                order.cust_order.order_date <= dataDo

                select order.price
                ).Sum();
        }
        #endregion
    }
}
