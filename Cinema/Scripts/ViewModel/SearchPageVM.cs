using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cinema.Scripts.ViewModel
{
    public class SearchPageVM: INotifyPropertyChanged
    {

        public SearchPageVM()
        {
            IsMenuClosed = App.MainVM.IsMenuClosed;
        }

        #region Commands

        #endregion


        #region Properties

        #region IsMenuClosed
        private bool isMenuClosed;
        public bool IsMenuClosed
        {
            get => isMenuClosed;
            set
            {
                isMenuClosed = value;
                OnPropertyChanged("IsMenuClosed");
            }
        }
        #endregion

        #region OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

        #endregion
    }
}
