using GalaSoft.MvvmLight.Messaging;
using Projekcik.Helpers;
using Projekcik.Models.Entities;
using Projekcik.Models.EntitiesForAllView;
using Projekcik.ViewModels.Abstract;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Projekcik.ViewModels
{
    public class CustomersViewModel:WszystkieViewModel<CustomerForAllView>
    {
        #region select
        private CustomerForAllView _SelectedCustomer;
        public CustomerForAllView SelectedCustomer
        {
            get
            {
                return _SelectedCustomer;
            }
            set
            {
                if (_SelectedCustomer != value)
                {
                    _SelectedCustomer = value;
                    Messenger.Default.Send(_SelectedCustomer);
                    //i zamknac okno z kontrahentami
                    //OnRequestClose();
                }
            }
        }
        #endregion

        public CustomersViewModel():base("Klienci")
        {

        }

        #region Command
        private BaseCommand _AddCustomerCommand;
        public ICommand AddCustomerCommand
        {
            get
            {
                if (_AddCustomerCommand == null)
                {
                    _AddCustomerCommand = new BaseCommand(() => addCustomer());
                }
                return _AddCustomerCommand;
            }
        }
        private void addCustomer()
        {
            Messenger.Default.Send("AddCustomer");
        }
        private BaseCommand _RefreshCustomerCommand;
        public ICommand RefreshCustomerCommand
        {
            get
            {
                if (_RefreshCustomerCommand == null)
                {
                    _RefreshCustomerCommand = new BaseCommand(() => Load());
                }
                return _RefreshCustomerCommand;
            }
        }
        #endregion


        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<CustomerForAllView>
                (
                  from customer in BookStoreEntities.customer //dla kazdej ....
                  select new CustomerForAllView //tworzymy ....
                  {
                      CustomerId =customer.customer_id,
                      FirstName = customer.first_name,
                      LastName = customer.last_name,    
                      Email = customer.email,
                     Country = customer.address.country.country_name,
                     City = customer.address.city,
                     StreetName = customer.address.street_name,
                     Numer = customer.address.street_number,
                     Adress_Stat = customer.address_status.address_status1
                  }
                );
        }
        
        #endregion
        #region FindAndSort
        public override void Sort()
        {
            if (SortField == "Miasto")
            {
                List = new ObservableCollection<CustomerForAllView>(List.OrderBy(item => item.City));
            }
            if (SortField == "Nieaktualny adres")
            {
                List = new ObservableCollection<CustomerForAllView>(List.Where(item => item.Adress_Stat=="Nieaktualny"));
            }
            if (SortField == "Wszyscy")
            {
                Load();
            }
        }

        public override List<string> GetComboBoxSortList()
        {
            return new List<string> { "Miasto", "Nieaktualny adres", "Wszyscy" };
        }

        public override void Find()
        {
            if (FindField == "Imię")
            {
                List = new ObservableCollection<CustomerForAllView>(List.Where(item => item.FirstName != null && item.FirstName.StartsWith(FindTextBox)));
            }
            if (FindField == "Nazwisko")
            {
                List = new ObservableCollection<CustomerForAllView>(List.Where(item => item.LastName != null && item.LastName.StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboBoxFindList()
        {
            return new List<string> { "Imię", "Nazwisko" };
        }
        #endregion
    }
}
