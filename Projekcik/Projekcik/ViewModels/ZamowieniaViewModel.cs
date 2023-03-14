using GalaSoft.MvvmLight.Messaging;
using Projekcik.Helpers;
using Projekcik.Models.Entities;
using Projekcik.Models.Entities.EntitiesForAllView;
using Projekcik.Models.EntitiesForAllView;
using Projekcik.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekcik.ViewModels
{
    public class ZamowieniaViewModel : WszystkieViewModel<OrderForAllView>
    {

        
        #region Konstruktor
        public ZamowieniaViewModel()
            :base("Zamowienia")
        {
            
        
        }
        #endregion

        #region Command
        private BaseCommand _AddZamowienieCommand;
        public ICommand AddZamowienieCommand
        {
            get
            {
                if (_AddZamowienieCommand == null)
                {
                    _AddZamowienieCommand = new BaseCommand(() => addZamowienie());
                }
                return _AddZamowienieCommand;
            }
        }
        private void addZamowienie()
        {
            Messenger.Default.Send("AddZamowienie");
        }
        private BaseCommand _RefreshZamowieniaCommand;
        public ICommand RefreshZamowieniaCommand
        {
            get
            {
                if (_RefreshZamowieniaCommand == null)
                {
                    _RefreshZamowieniaCommand = new BaseCommand(() => Load());
                }
                return _RefreshZamowieniaCommand;
            }
        }
        #endregion

        public override void Load()
        {
            List = new ObservableCollection<OrderForAllView>
                (
                from order in BookStoreEntities.cust_order
                select new OrderForAllView
                {
                    ordId= order.order_id,
                    CustomerId = order.customer_id,
                    OrderDate = order.order_date,
                    Cena = order.order_line1.price
                }
                );
        }

        public override void Sort()
        {
            if(SortField == "Data")
            {
                List = new ObservableCollection<OrderForAllView>(List.OrderBy(item => item.OrderDate));
            }
        }
        public override void Find()
        {
            if (FindField == "Id Klienta")
            {
                List = new ObservableCollection<OrderForAllView>(List.Where(item => item.CustomerId != null && item.CustomerId.ToString().StartsWith(FindTextBox)));
            }
            if (FindField == "Nazwisko")
            {
                List = new ObservableCollection<OrderForAllView>(List.Where(item => item.ordId != null && item.ordId.ToString().StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboBoxFindList()
        {
            return new List<string> { "Id zamówienia", "Id Klienta" };
        }

        public override List<string> GetComboBoxSortList()
        {
            return new List<string> { "Data" };
        }
    }


        
       
        }
    


