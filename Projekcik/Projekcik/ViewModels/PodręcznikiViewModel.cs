using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.ViewModels
{
    public class PodręcznikiViewModel: WorkSpaceViewModel // bo wszystkie zakładki dziedziczą po WorkSpaceViewModel
    {
        #region Konstruktor
        public PodręcznikiViewModel()
        {
            base.DisplayName = "Podręczniki";
        }
        #endregion
    }
}
