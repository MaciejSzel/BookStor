using Projekcik.Helpers;
using Projekcik.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekcik.ViewModels.Abstract
{
    public abstract class WszystkieViewModel<T> : WorkSpaceViewModel // bo wszystkie zakladki dziedzicza po workspaceviewmodel
    {
        #region Fields
        private readonly BookStoreEntities bookStoreEntities;
        public BookStoreEntities BookStoreEntities 
        { 
            get
            {
                return bookStoreEntities;
            }
        }
        //Komenda do ładowania książek
        private BaseCommand _LoadCommand;

        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new BaseCommand(() => Load());
                }
                return _LoadCommand;
            }
        }

        //w tym obiekcie beda wszystkie książki
        private ObservableCollection<T> _List;
        public ObservableCollection<T> List
        {
            get
            {
                if (_List == null) // jak lista jest pusta wywolujemy load zeby zaladowac książki
                    Load();
                return _List;
            }
            set
            {
                _List = value;
                OnPropertyChanged(() => List);
            }
        }


        #endregion
        #region MyRegion
        public WszystkieViewModel(string displayName)
        {
            base.DisplayName = displayName; // tu ustawiamy nazwę zakładki
            this.bookStoreEntities = new BookStoreEntities();
        }
        #endregion
        #region Helpers
        public abstract void Load();
        #endregion

        #region Sort
        //to jest komenda, ktora zostanie podpieta pod przycisk Sortuj

        //wywola ona funkcje Sort()
        private BaseCommand _SortCommand;
        public ICommand SortCommand
        {
            get
            {
                if (_SortCommand == null)
                {
                    _SortCommand = new BaseCommand(() => Sort());
                }
                return _SortCommand;
            }
        }

        public abstract void Sort();
        //To jest pole wyboru tego po czym bedzie sortowac
        public string SortField { get; set; }

        // to jest properties ktory wypelnia opcje wyboru w comboBoxie na bazie funcji
        public List<string> SortComboBoxItems
        {
            get
            {
                return GetComboBoxSortList();
            }
        }
        public abstract List<string> GetComboBoxSortList();
        #endregion

        #region Find
        //To jest komenda ktora zostanie podpieta pod przycisk filtruj
        private BaseCommand _FindCommand;
        //wywola ona funkcje Find
        public ICommand FindCommand
        {
            get
            {
                if (_FindCommand == null)
                {
                    _FindCommand = new BaseCommand(() => Find());
                }
                return _FindCommand;
            }
        }
        public abstract void Find();
        //to jest wlasciwosc w ktorej zostanie zapisany wybor pola po ktorym bedziemy wyszukiwac
        public string FindField { get; set; }
        //to jest wlasciwosc w ktorej zostanie zapisany poczatek frazy wyszukujacej i ktora zostanie podpisana pod texbox
        public string FindTextBox { get; set; }
        public string FindComboBox { get; set; }

        public List<string> FindComboBoxItems
        {
            get
            {
                return GetComboBoxFindList();
            }
        }
        public abstract List<string> GetComboBoxFindList();
        #endregion

    }
}
