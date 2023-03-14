using GalaSoft.MvvmLight.Messaging;
using Projekcik.Models.EntitiesForAllView;
using Projekcik.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.ViewModels
{
    public class AuthorsViewModel : WszystkieViewModel<AuthorForAllView>
    {
        public AuthorsViewModel() : base("Autorzy")
        {
        }

        private AuthorForAllView _SelectedAuthor;
        public AuthorForAllView SelectedAuthor
        {
            get
            {
                return _SelectedAuthor;
            }
            set
            {
                if (_SelectedAuthor != value)
                {
                    _SelectedAuthor = value;
                    Messenger.Default.Send(_SelectedAuthor);
                    //base.OnRequestClose();
                    //OnRequestClose();
                }
            }
        }

        public override void Find()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetComboBoxFindList()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetComboBoxSortList()
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            List = new ObservableCollection<AuthorForAllView>
                (
                from authors in BookStoreEntities.author
                select new AuthorForAllView
                {
                    AuthorName= authors.author_name
                }
                
                );
        }

        public override void Sort()
        {
            throw new NotImplementedException();
        }
    }
}
