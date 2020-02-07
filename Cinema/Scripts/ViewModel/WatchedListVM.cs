using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cinema.Scripts.Model;

namespace Cinema.Scripts.ViewModel
{
    public class WatchedListVM : INotifyPropertyChanged
    {
        #region Commands

        #endregion

        #region Properties

        #region WatchedTitles

        private List<TitleInfo> watchedTitles = new List<TitleInfo>();
        public List<TitleInfo> WatchedTitles
        {
            get => watchedTitles;
            set
            {
                watchedTitles = value;
                OnPropertyChanged("WatchedTitles");
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
