using GalaSoft.MvvmLight.Messaging;
using Projekcik.Helpers;
using Projekcik.Models.Entities;
using Projekcik.Models.Entities.EntitiesForAllView;
using Projekcik.Models.EntitiesForAllView;
using Projekcik.Models.Validators;
using Projekcik.ViewModels.Abstract;
using Projekcik.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Projekcik.ViewModels
{
    public class KsiążkiViewModel: WszystkieViewModel<BookForAllView>
    {   

        private BookForAllView _SelectedBook;
        public BookForAllView SelectedBook
        {
            get { return _SelectedBook; }
            set
            {
                if (_SelectedBook != value)
                {
                    _SelectedBook = value;
                    Messenger.Default.Send(_SelectedBook);
                }
            }
        }
        #region Konstruktor
        public KsiążkiViewModel()
            :base("Książki")
        {
                       
        }
        #endregion

        #region Command
        private BaseCommand _AddBookCommand;
        public ICommand AddBookCommand
        {
            get
            {
                if (_AddBookCommand == null)
                {
                    _AddBookCommand = new BaseCommand(() => addBook());
                }
                return _AddBookCommand;
            }
        }
        private void addBook()
        {
            Messenger.Default.Send("AddBook");
        }
        private BaseCommand _RefreshBookCommand;
        public ICommand RefreshBookCommand
        {
            get
            {
                if (_RefreshBookCommand == null)
                {
                    _RefreshBookCommand = new BaseCommand(() => Load());
                }
                return _RefreshBookCommand;
            }
        }
        #endregion
        #region Helpers
        public IQueryable<BookForAllView> KontrahenciComboBoxItems
        {
            get
            {
                return
                    (
                      from kontrahent in BookStoreEntities.book_language
                      select new BookForAllView
                      {
                          Language_code=kontrahent.language_name
                      }
                      
                    ).ToList().AsQueryable();
            }
        }
        public override void Load()
        {
            List = new ObservableCollection<BookForAllView>
               (
               from book in BookStoreEntities.book
               select new BookForAllView
               {
                   BookId = book.book_id,
                   Title = book.title,
                   Language_code = book.book_language.language_code,
                   Language_name = book.book_language.language_name,
                   Pages = book.num_pages,
                   PublicationDate = book.publication_date,
                   PublisherName = book.publisher.publisher_name,
                   Author = book.author.author_name,
                   Cena = book.Cena
               }
               );    
        }
        #endregion
        #region FindAndSort
        public override void Sort()
        {
            if (SortField == "Liczba stron")
            {
                List = new ObservableCollection<BookForAllView>(List.OrderBy(item => item.Pages));
            }
            if (SortField == "Data wydania")
            {
                List = new ObservableCollection<BookForAllView>(List.OrderBy(item => item.PublicationDate));
            }
            if (SortField == "Wszyscy")
            {
                Load();
            }
        }

        public override List<string> GetComboBoxSortList()
        {
            return new List<string> { "Wszyscy", "Liczba stron", "Data wydania" };
        }

        public override void Find()
        {
            if (FindField == "Tytuł")
            {
                List = new ObservableCollection<BookForAllView>(List.Where(item => item.Title != null && item.Title.StartsWith(FindTextBox)));
            }
            if (FindField == "Język")
            {
                List = new ObservableCollection<BookForAllView>(List.Where(item => item.Language_name != null && item.Language_name.StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboBoxFindList()
        {
            return new List<string> { "Tytuł", "Język" };
        }
        #endregion
       
    }


}


