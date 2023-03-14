using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekcik.ViewModels
{
    //To jest klasa która jest po to żeby Tworzyć komendy w menu z lewej strony
    public class CommandViewModel:BaseViewModel
    {
        #region Properties
        public string DisplayName { get; set; } // nazwa przycisku w menu z lewej strony
        public ICommand Command { get; set; } // kazdy przycisk zawiera komende, ktora wywoluje funkcje ktora wywola zakladke

        #endregion
        #region Konstruktor
        public CommandViewModel(string displayName, ICommand command)
        {
            if (command == null) throw new ArgumentNullException("Command");
            this.DisplayName = displayName;
            this.Command = command;
        }
        #endregion
    }
}
