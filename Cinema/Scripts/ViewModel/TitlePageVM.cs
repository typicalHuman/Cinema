using Cinema.Scripts.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Scripts.ViewModel
{
    public class TitlePageVM : INotifyPropertyChanged
    {

        #region Constructor

        public TitlePageVM()
        {
            TitleInfo = App.SearchPageVM.ResultTitles[App.SearchPageVM.SelectedIndex];
        }

        #endregion

        #region Properties

        #region SelectedTitle
        private TitleInfo titleInfo;
        public TitleInfo TitleInfo
        {
            get => titleInfo;
            set
            {
                titleInfo = value;
                OnPropertyChanged("TitleInfo");
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
