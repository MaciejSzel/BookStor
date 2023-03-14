﻿using Projekcik.Helpers;
using Projekcik.Models.BusinessLogic;
using Projekcik.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekcik.ViewModels
{
    public class CustomerOrdersViewModel : WorkSpaceViewModel
    {
        #region Properties
        public BookStoreEntities BookStoreEntities { get; set; }
        private int _CustomerId;
        public int CustomerId
        {
            get
            {
                return _CustomerId;
            }
            set
            {
                if (value != _CustomerId)
                {
                    _CustomerId = value;
                    OnPropertyChanged(() => CustomerId);
                }
            }
        }
        private DateTime _DataOd;
        public DateTime DataOd
        {
            get
            {
                return _DataOd;
            }
            set
            {
                if (value != _DataOd)
                {
                    _DataOd = value;
                    OnPropertyChanged(() => DataOd);
                }
            }
        }
        private DateTime _DataDo;
        public DateTime DataDo
        {
            get
            {
                return _DataDo;
            }
            set
            {
                if (value != _DataDo)
                {
                    _DataDo = value;
                    OnPropertyChanged(() => DataDo);
                }
            }
        }
        private decimal? _Wartosc;
        public decimal? Wartosc
        {
            get
            {
                return _Wartosc;
            }
            set
            {
                if (value != _Wartosc)
                {
                    _Wartosc = value;
                    OnPropertyChanged(() => Wartosc);
                }
            }
        }

            #endregion

        #region Komendy
        private BaseCommand _ObliczCommand;
        public ICommand ObliczCommand
        {
            get
            {
                if (_ObliczCommand == null)
                {
                    _ObliczCommand = new BaseCommand(() => WartoscZamowienKlienta());
                }
                return _ObliczCommand;
            }
        }

        #endregion
        #region Helpers
        private void WartoscZamowienKlienta()
        {
            //Wykorzystujemy tu funkcje logiki biznesowej
            Wartosc = new CustomerOrdersValue(BookStoreEntities).WartoscZamowienKlienta(CustomerId, DataOd, DataDo);
        }
        #endregion
        #region Konstruktor
        public CustomerOrdersViewModel()
        {
            base.DisplayName = "Utarg";
            BookStoreEntities = new BookStoreEntities();
            //Domyslne wartosci po uruchomieniu.
            DataOd = DateTime.Now;
            DataDo = DateTime.Now;
            Wartosc = 0;
        }
        #endregion
    }
}
