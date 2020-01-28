using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Cinema.Scripts.Model;

namespace Cinema.Scripts.ViewModel
{
    public class SearchPageVM: INotifyPropertyChanged
    {

        public SearchPageVM()
        {
            IsMenuClosed = App.MainVM.IsMenuClosed;
            ResultTitles = new ObservableCollection<TitleInfo>();
        }

        #region Commands

        #endregion


        #region Properties

        #region ResultTitles
        public ObservableCollection<TitleInfo> ResultTitles { get; set; }

        #endregion


        #region IsSearching

        private bool isSearching;
        public bool IsSearching
        {
            get => isSearching;
            set
            {
                isSearching = value;
                OnPropertyChanged("IsSearching");
            }
        }

        #endregion

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
