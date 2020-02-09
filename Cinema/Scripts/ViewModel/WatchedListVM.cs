using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cinema.Scripts.Model;
using System.Windows;

namespace Cinema.Scripts.ViewModel
{
    public class WatchedListVM : INotifyPropertyChanged
    {

        #region Properties

        #region WatchedTitles

        private List<TitleInfo> watchedTitles = new List<TitleInfo>();
        public List<TitleInfo> WatchedTitles
        {
            get
            {
                if (watchedTitles?.Count > 0)
                    Visibility = Visibility.Hidden;
                else
                    Visibility = Visibility.Visible;
                return watchedTitles;
            }
            set
            {
                watchedTitles = value;
                OnPropertyChanged("WatchedTitles");
            }
        }

        #endregion

        #region StatusTextVisibility

        private Visibility visibility = Visibility.Visible;
        public Visibility Visibility
        {
            get => visibility;
            set
            {
                visibility = value;
                OnPropertyChanged("Visibility");
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
