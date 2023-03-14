using GalaSoft.MvvmLight.Messaging;
using Projekcik.Helpers;
using Projekcik.Models.Entities;
using Projekcik.Models.EntitiesForAllView;
using Projekcik.Models.Validators;
using Projekcik.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace Projekcik.ViewModels
{
    public class NowaKsiążkaViewModel : JedenViewModel<book>, IDataErrorInfo
    { 
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
                if (name == "Title")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(Title);
                }
                if (name == "LanguageName")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(LanguageName);
                }
                if (name == "PublisherName")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(PublisherName);
                }
                if (name == "Price")
                {
                    komunikat = CenaValidator.SprawdzCena(Price);
                }

                return komunikat;
            }
        }
        public override bool IsValid()
        {
            if (this["Title"] == null)
            {
                return true;
            }
            if (this["LanguageName"] == null)
            {
                return true;
            }
            if (this["PublisherName"] == null)
            {
                return true;
            }
            if (this["Price"] == null)
            {
                return true;
            }

            return false;
        }
        #endregion
        private BaseCommand _ShowAutorzy;
        public ICommand ShowAutorzy
        {
            get
            {
                if (_ShowAutorzy == null)
                {
                    _ShowAutorzy = new BaseCommand(() => showAutorzy());
                }
                return _ShowAutorzy;
            }
        }
        private void showAutorzy()
        {
            Messenger.Default.Send("Autorzy");
        }
        #region Konstruktor


        public NowaKsiążkaViewModel() : base("Nowa książka")
        {
            Item = new book();
            Messenger.Default.Register<AuthorForAllView>(this, getWybranyAutor);
        }
        #endregion
        public string Title { get; set; }
        public string Language_Code { get; set; }
        public string LanguageName { get; set; }
        public int? Pages { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string PublisherName { get; set; }
        public decimal Price { get; set; }
        private string _AuthorName;
        public string AuthorName
        {
            get { return _AuthorName; }
                set
                {
                    if (_AuthorName != value)
                        _AuthorName = value;
                    base.OnPropertyChanged(() => _AuthorName);
                }
        }


        //propki od inkrementowanie id FK zeby dzialalo wyswietlanie z kluczem obcym 
        public int lang_id { get; set; }
        public int pub_id { get; set; }
        //w tabeli orderline
        public int bookId { get; set; }
        public int AuthorId { get; set; }
        public int? PriceId { get; set; }
        public decimal? Cena { get; set; }

        public IQueryable<KeyAndValue> LanguageCodeComboBoxItems
        {
            get
            {
                return
                    (
                      from sposobPlatnosci in Db.book_language
                      select new KeyAndValue
                      {
                          Key = sposobPlatnosci.language_id,
                          Value = sposobPlatnosci.language_code
                      }
                    ).ToList().AsQueryable();
            }
        }
        public override void Save()
        {
            using (BookStoreEntities context = new BookStoreEntities())
            {
                book Book = new book
                {
                    title = Title,
                    num_pages = Pages,
                    publication_date = PublicationDate,
                    language_id = lang_id,
                    publisher_id = pub_id++,
                    Cena = Cena,
                    AuthorId = AuthorId++
                    
                    
                };
                book_language language = new book_language
                {
                    language_code = Language_Code,
                    language_name = LanguageName
                };
                publisher publisher = new publisher
                {
                    publisher_name = PublisherName
                };
                order_line order_Line = new order_line
                {
                    price = Price,
                    book_id = bookId++
                };
                author author = new author
                {
                    author_name = AuthorName,
                };
                context.book.AddObject(Book);
                context.book_language.AddObject(language);
                context.publisher.AddObject(publisher);
                context.order_line.AddObject(order_Line);
                context.author.AddObject(author);
                context.SaveChanges();
            };
        }
        private void getWybranyAutor(AuthorForAllView authorForAllView)
        {
           

            //to jest funkcja ktora jest uruchamiana po przeslaniu z okna wszyscy kontrahenci wybranego kontrahenta
            AuthorName = authorForAllView.AuthorName;
        }
    }
}
