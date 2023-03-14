using Projekcik.Helpers;
using Projekcik.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Projekcik.ViewModels.Abstract
{
    public abstract class JedenViewModel<T> : WorkSpaceViewModel
    {
        #region Fields
        public BookStoreEntities Db { get; set; }
        public T Item { get; set; }
        #endregion
        #region Konstruktor
        public JedenViewModel(string displayName)
        {
            base.DisplayName = displayName;
            Db = new BookStoreEntities();
        }
        #endregion

        #region Command
        //to...
        private BaseCommand _SaveAndCloseCommand;
        public ICommand SaveAndCloseCommand
        {
            get
            {
                if (_SaveAndCloseCommand == null)
                {
                    _SaveAndCloseCommand = new BaseCommand(() => saveAndClose());
                }
                return _SaveAndCloseCommand;
            }
        }
        #endregion
        #region Validation
        public virtual bool IsValid()
        {
            return true;
        }
        #endregion
        #region Save
        public abstract void Save();
        private void saveAndClose()
        {
            if (IsValid())
            {
                //zapisuje towar
                Save();
                //zamyka zakladke
                base.OnRequestClose();
            }
            else
            {
                MessageBox.Show("Popraw wszystkie dane.");
            }
        }
        #endregion
    }
}

