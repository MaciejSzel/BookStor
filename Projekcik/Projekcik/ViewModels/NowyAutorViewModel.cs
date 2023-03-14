using Projekcik.Models.Entities;
using Projekcik.Models.EntitiesForAllView;
using Projekcik.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.ViewModels
{
    public class NowyAutorViewModel : JedenViewModel<AuthorForAllView>
    {
        public NowyAutorViewModel():base("Nowy autor")
        {
            
        }

        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                if(Id != value)
                {
                    value = Id;
                    base.OnPropertyChanged(()=>Id);
                }
            }
        }
        public string AuthorName { get; set; }
        public override void Save()
        {
            using(BookStoreEntities context = new BookStoreEntities())
            {
                author author = new author
                {
                    author_name = AuthorName,
                };
                //book_author book_Author = new book_author();
                context.author.AddObject(author);
                context.SaveChanges();

            }
        }
    }
}
