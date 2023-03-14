using GalaSoft.MvvmLight.Messaging;
using Projekcik.Helpers;
using Projekcik.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Projekcik.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
       
        //bedzie zawieral kolekcje komend ktore pojawiaja sie w  menu lewym oraz kolekcje zakladek
        #region Komendy menu i paska narzędzi

        //public ICommand NowyTowarCOmmand
        //{
        //    get
        //    {
        //        return new BaseCommand(() => createView(new NowyTowarViewModel()));
        //    }
        //}
        public ICommand KsiążkiCommand 
        {
            get
            {
                return new BaseCommand(showAllKsiążki);
            }
            
        }
        #endregion
        #region Przyciski w menu z lewej strony
        private ReadOnlyCollection<CommandViewModel> _Commands; // kolekcja komend w menu lewym
        public ReadOnlyCollection<CommandViewModel> Commands
        {
            get 
            {
                if( _Commands == null )//sprawdzam czy przyciski z lewej strony menu nie zostaly zainicjalizowane
                {
                    List<CommandViewModel> cmds = this.CreateCommands(); //Tworzę listę przycsków za pomoca funkcji createCommands
                    _Commands = new ReadOnlyCollection<CommandViewModel>( cmds );//liste przypisuje do ReadOnlyCollection bo readonlycollection mozna tylko tworzyc
                }
                return _Commands;
            }
           
        }
        private List<CommandViewModel> CreateCommands() // tu decydujemy jakie przyciski sa w menu z lewej strony
        {
            Messenger.Default.Register<string>(this, open);
            return new List<CommandViewModel>
            {
                new CommandViewModel("Książki", new BaseCommand(showAllKsiążki)), //to tworzy pierwszy przycisk o nazwie ksiazki ktory pokaze zakladke ksiazki to tworzy pierwszy przycisk o nazwie ksiazki ktory pokaze zakladke ksiazki
                 new CommandViewModel("Nowa książka", new BaseCommand(()=>createView(new NowaKsiążkaViewModel()))),
                new CommandViewModel("Zamówienia", new BaseCommand(()=>createView(new ZamowieniaViewModel()))), // zamiast funkcji np createTowar
                 new CommandViewModel("Nowe zamówienia", new BaseCommand(()=>createView(new NoweZamowienieViewModel()))),
                 new CommandViewModel("Nowy klient", new BaseCommand(()=>createView(new NewCustomerViewModel()))),
                new CommandViewModel("Klienci", new BaseCommand(()=>createView(new CustomersViewModel()))),
                new CommandViewModel("Autorzy", new BaseCommand(()=>createView(new AuthorsViewModel()))),
                new CommandViewModel("Nowy autor", new BaseCommand(()=>createView(new NowyAutorViewModel()))),
                new CommandViewModel("Wartość Książek", new BaseCommand(()=>createView(new BooksValueViewModel()))),
                new CommandViewModel("Utarg", new BaseCommand(()=>createView(new OrderValueViewModel()))),
                new CommandViewModel("Zamowienia Klienta", new BaseCommand(()=>createView(new CustomerOrdersViewModel()))),
               //new CommandViewModel("Zamówienia", new BaseCommand(()=>createView(new Zamowienia1ViewModel()))), // zamiast funkcji np createTowar
            };
        }
        #endregion

        #region Zakladki
        private ObservableCollection<WorkSpaceViewModel> _Workspaces; // to jest kolekcja zakladek
        public ObservableCollection<WorkSpaceViewModel> Workspaces
        {
            get
            {
                if( _Workspaces == null )
                {
                    _Workspaces = new ObservableCollection<WorkSpaceViewModel>();
                    _Workspaces.CollectionChanged += this.onWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        private void onWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e) 
        { 
            if (e.NewItems != null && e.NewItems.Count != 0) 
                foreach (WorkSpaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += this.onWorkspaceRequestClose;
            if (e.OldItems != null && e.OldItems.Count != 0) 
                foreach (WorkSpaceViewModel workspace in e.OldItems) 
                    workspace.RequestClose -= this.onWorkspaceRequestClose;
        }
        private void onWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkSpaceViewModel workspace = sender as WorkSpaceViewModel; //workspace.Dispos();
            this.Workspaces.Remove(workspace);
        }
        #endregion
        #region Funkcje Pomocnicze

        //24 minuta wykladu funkcja createTowar aka dodaj u mnie

        //to jest funckja ktora otwiera zakladke z wszystkimi ksiazkami
        //za kazdym razem sprawdza czy zakladka z ksiazkami jest juz otwarta, jak jest to ja aktywuje
        
        private void createView(WorkSpaceViewModel workspace)
        {
            this.Workspaces.Add(workspace);
            this.setActiveWorkspace(workspace);
        }
          

        private void showAllKsiążki()
        {
            //Szukamy w kolekcji zakładek takiej zakladki ktora jest Książkami
            KsiążkiViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is KsiążkiViewModel) as KsiążkiViewModel;
            //Jezeli takiej zakladki nie ma to bedziemy ja tworzyc/dodawac
            if(workspace == null)
            {
                //to tworzymy zakladke ksiazki 
                workspace = new KsiążkiViewModel();
                //i dodajemy do kolekcji zakladek
                this.Workspaces.Add(workspace);
            }
            //aktywujemy zakladke
            this.setActiveWorkspace(workspace);

        }
        private void showAllPodręczniki()
        {
            PodręcznikiViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is PodręcznikiViewModel) as PodręcznikiViewModel;


            if (workspace == null)
            {
                workspace = new PodręcznikiViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);

        }

       
        private void setActiveWorkspace(WorkSpaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));

            ICollectionView colectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if(colectionView != null)
                colectionView.MoveCurrentTo(workspace);
        }

        private void open(string name)
        {
            //jezeli komunikat jest TowaryAdd to wlaczamy okno do dodawania nowego towaru
            if (name == "CustomerFlying")
            {
                createView(new CustomersViewModel());
            }
            if(name == "AddBook")
            {
                createView(new NowaKsiążkaViewModel());
            }
            if(name== "AddCustomer")
            {
                createView(new NewCustomerViewModel());
            }
            if (name == "AddZamowienie")
            {
                createView(new NoweZamowienieViewModel());
            }
            if (name== "Autorzy")
            {
                createView(new AuthorsViewModel());
            }
            if(name == "BookFlying")
            {
                createView(new KsiążkiViewModel());
            }
           
        }
        #endregion

    }
}
