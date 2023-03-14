using Projekcik.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekcik.ViewModels
{
    // To jest klasa z któej będą dziedziczyć wszystkie ViewModele zakladek
    public class WorkSpaceViewModel:BaseViewModel
    {
        #region Pola i komendy
        //Każda zakładka ma minimum nazwę i zamknij
        public string DisplayName { get; set; } // w tym propertiesie bedzie nazwa zakladki
        private BaseCommand _CloseCommand; //To jest komenda do obsługi zamykania okna

        public ICommand CloseCommand
        {
            get
            {
                if (_CloseCommand == null)
                    _CloseCommand = new BaseCommand(() => this.OnRequestClose()); //Ta komenda wywoła funkcje zamykającą zakładke
                return _CloseCommand;
            }
        }
        #endregion
        #region RequestClose [event]
        public event EventHandler RequestClose; 
        public void OnRequestClose()
        {
            EventHandler handler = this.RequestClose;
            if (handler != null) 
                handler(this, EventArgs.Empty);
        } 
        #endregion
    }
}
