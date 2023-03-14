using GalaSoft.MvvmLight.Messaging;
using Projekcik.Helpers;
using Projekcik.Models.Entities;
using Projekcik.Models.Entities.EntitiesForAllView;
using Projekcik.Models.EntitiesForAllView;
using Projekcik.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekcik.ViewModels
{
    public class NoweZamowienieViewModel : JedenViewModel<customer>
    {
        #region Command
        //To jest komenda ktora zostanie podpieta pod przycisk z trzema kropkami i wywola ona funkcje showKontrahenci
        private BaseCommand _ShowCustomersCommand;
        public ICommand ShowCustomersCommand
        {
            get
            {
                if (_ShowCustomersCommand == null)
                {
                    _ShowCustomersCommand = new BaseCommand(() => showCustomers());
                }
                return _ShowCustomersCommand;
            } 
        }
        private BaseCommand _showBookCommand;
        public ICommand ShowBookCommand
        {
            get
            {
                if (_showBookCommand == null)
                {
                    _showBookCommand = new BaseCommand(() => showBooks());
                }
                return _showBookCommand;
            }
        }
        private void showCustomers()
        {
            Messenger.Default.Send("CustomerFlying");
        }
        private void showBooks()
        {
            Messenger.Default.Send("BookFlying");
        }


        #endregion

        public NoweZamowienieViewModel()
            :base("Nowe Zamowienie")
        {
            Item = new customer();
            OrderDate = DateTime.Now;
            Messenger.Default.Register<CustomerForAllView>(this, getSelectedCustomer);   
            Messenger.Default.Register<BookForAllView>(this, getSelectedBook);   
        }
        

        public override void Save()
        {
            using(BookStoreEntities context = new BookStoreEntities())
            {
                cust_order cust_Order = new cust_order
                {
                    customer_id = CustomerId,
                    order_date = DateTime.Now,
                };
                order_line line = new order_line
                { 
                    order_id = ordId++,
                    price= Price,
                };

                context.cust_order.AddObject(cust_Order);
                context.order_line.AddObject(line);
                context.SaveChanges();
            }
        }

        //+ powinny mieć jeszcze pole, czyli np. private string _FirstName Sprawdze ale wydaje mi sie ze to nic nie zmieni  zobaczymy
        //Tak powinien każdy properties wyglądać, nawet jak ma tylko wyświetlać dane w tym :( Zaczalem to robic i Ty tez akurat zaczelas :D ale juz sie ogarnelo
        #region Propki
        //customer prop
        private string _FirstName;
        public string FirstName
        {
            get
            {
                return _FirstName;
            }

            set
            {
                if (value != _FirstName)
                {
                    _FirstName = value;
                    base.OnPropertyChanged(() => _FirstName);
                }
            }
        }
        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                if (value != _LastName)
                {
                    _LastName = value;
                    base.OnPropertyChanged(() => LastName);
                }
            }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set
            {
                if (value != _Email)
                {
                    _Email = value;
                    base.OnPropertyChanged(() => Email);
                }
            }
        }

        private string _StreetName;
        public string StreetName
        {
            get { return _StreetName; }
            set
            {
                if (value != _StreetName)
                {
                    _StreetName = value;
                    base.OnPropertyChanged(() => StreetName);
                }
            }
        }
        private string _Numer;
        public string Numer
        {
            get { return _Numer; }
            set
            {
                if (value != _Numer)
                {
                    _Numer = value;
                    base.OnPropertyChanged(() => Numer);
                }
            }
        }
        private string _Country;
        public string Country
        {
            get { return _Country; }
            set
            {
                if (value != _Country)
                {
                    _Country = value;
                    base.OnPropertyChanged(() => Country);
                }
            }
        }
        private string _City;
        public string City
        {
            get { return _City; }
            set
            {
                if (value != _City)
                {
                    _City = value;
                    base.OnPropertyChanged(() => City);
                }
            }
        }
        public int adres_id { get; set; }
        public int country_id { get; set; }
        private int _stat_id;
        public int stat_id
        {
            get
            {
                return _stat_id;
            }

            set
            {
                if (value != _stat_id)
                {
                    _stat_id = value;
                    base.OnPropertyChanged(() => _stat_id);
                }
            }
        }
        private int _CustomerId;
        public int CustomerId
        {
            get
            {
                return _CustomerId;
            }
            set
            {
                if (_CustomerId != value)
                {
                    _CustomerId = value;
                    base.OnPropertyChanged(() => CustomerId);
                }
            }
        }
        public IQueryable<KeyAndValue> ShippingMethodComboBoxItems
        {
            get
            {
                return
                    (
                      from shipping in Db.shipping_method
                      select new KeyAndValue
                      {
                          Key = shipping.method_id,
                          Value = shipping.method_name
                      }
                    ).ToList().AsQueryable();
            }
        }
        //end of customer props

        //book prop
        private string _Title;
        public string Title
        {
            get { return _Title; }
            set
            {
                if (value != _Title)
                {
                    _Title = value;
                    base.OnPropertyChanged(()=>_Title);
                }
            }
        }
        private string _LanguageName;
        public string LanguageName
        {
            get { return _LanguageName; }
            set
            {
                if (value != _LanguageName)
                {
                    _LanguageName = value;
                    base.OnPropertyChanged(() => _LanguageName);
                }
            }
        }
        private DateTime? _PublicationDate;
            public DateTime? PublicationDate
        {
            get { return _PublicationDate; }
            set
            {
                if (value != _PublicationDate)
                {
                    _PublicationDate = value;
                    base.OnPropertyChanged(() => _PublicationDate);
                }
            }
        }
        private string _Author;
            public string Author
        {
            get { return _Author; }
            set 
            {
                if (value != _Author)
                {
                    _Author = value;
                    base.OnPropertyChanged(() => _Author);
                }
                    
            }
        }
        private decimal? _Price;
        public decimal? Price
        {
            get { return _Price; }
            set { _Price = value; base.OnPropertyChanged(() => _Price); }
        }
        //end Book prop

        //Zamowienie prop
        public DateTime? OrderDate { get; set; }
        public int ShippingMethodId { get; set; }
        public int ordId { get; set; }
        public IQueryable<KeyAndValue> OrderStatusComboBoxItems
        {
            get
            {
                return
                    (
                      from orderstatus in Db.order_status
                      select new KeyAndValue
                      {
                          Key = orderstatus.status_id,
                          Value = orderstatus.status_value
                      }
                    ).ToList().AsQueryable();
            }
        }

        #endregion






        //Tu przyjmujesz CustomerForAllView
        private void getSelectedCustomer(CustomerForAllView cust)
        {
            CustomerId = cust.CustomerId;
           FirstName = cust.FirstName;
            LastName = cust.LastName;
            Email = cust.Email;
            Country = cust.Country;
            City = cust.City;
            StreetName = cust.StreetName;
            Numer = cust.Numer;
            CustomerId = cust.CustomerId;

        }
        private void getSelectedBook(BookForAllView book)
        {
            Title = book.Title;
            LanguageName = book.Language_name;
            PublicationDate = book.PublicationDate;
            Author = book.Author;
            Price = book.Cena;
        }
     
    }
}
