using Projekcik.Models.Entities;
using Projekcik.Models.EntitiesForAllView;
using Projekcik.Models.Validators;
using Projekcik.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.ViewModels
{
    public class NewCustomerViewModel : JedenViewModel<customer>, IDataErrorInfo
    {
        public NewCustomerViewModel() :base("Nowy klient")
        {
            Item = new customer();
        }

       

        public string FirstName
        {
            get
            {
                return Item.first_name;
            }
            set
            {
                if (Item.first_name != value)
                {
                    Item.first_name = value;
                    base.OnPropertyChanged(() => FirstName);
                }
            }
        }
        public string LastName
        {
            get
            {
                return Item.last_name;
            }
            set
            {
                if (Item.last_name != value)
                {
                    Item.last_name = value;
                    base.OnPropertyChanged(() => LastName);
                }
            }
        }
        public string Email
        {
            get
            {
                return Item.email;
            }
            set
            {
                if (Item.email != value)
                {
                    Item.email = value;
                    base.OnPropertyChanged(() => Email);
                }
            }
        }
        public string StreetName { get; set; }
        public string Numer { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int adres_id { get; set; }
        public int country_id { get; set; }
        public int stat_id { get; set; }

        public IQueryable<KeyAndValue> AdressStatusComboBoxItems
        {
            get
            {
                return
                    (
                      from sposobPlatnosci in Db.address_status
                      select new KeyAndValue
                      {
                          Key = sposobPlatnosci.status_id,
                          Value = sposobPlatnosci.address_status1
                      }
                    ).ToList().AsQueryable();
            }
        }


        public override void Save()
        {
            using (BookStoreEntities context = new BookStoreEntities())
            {
                customer customer = new customer
                {
                    first_name = FirstName,
                    last_name = LastName,
                    email = Email,  
                    addres_id = adres_id++,
                    stat_id = stat_id
                    
                };
                address address = new address
                {
                    street_name = StreetName,
                    street_number = Numer,
                    city = City,
                    country_id = country_id++,
                    
                };
               country country = new country
               {
                   country_name = Country
               };
                
                context.customer.AddObject(customer);
                context.address.AddObject(address);
                context.country.AddObject(country);
                context.SaveChanges();
            };
        }
        #region Validation

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string name]
        {
            get
            {
                string komunikat = null;
                if(name == "Email")
                {
                    komunikat = EmailValidator.SprawdzCzyZawiera(Email);
                }
                if (name == "FirstName")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(FirstName);
                }
                if (name == "LastName")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(LastName);
                }
                if (name == "Country")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(Country);
                }
                if (name == "City")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(City);
                }
                if (name == "StreetName")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(StreetName);
                }
                if(name == "Numer")
                {
                    komunikat = MniejNizJeden.SprawdzCzyMniejszyOdJeden(Numer);
                }
                return komunikat;
            }
        }
        public override bool IsValid()
        {
            if(this["Email"]==null)
            {
                return true;
            }
            if (this["FirstName"] == null)
            {
                return true;
            }
            if (this["LastName"] == null)
            {
                return true;
            }
            if(this["Country"] ==null)
            {
                return true;
            }
            if (this["City"] == null)
            {
                return true;
            }
            if (this["StreetName"] == null)
            {
                return true;
            }
            if (this["Numer"] == null)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
