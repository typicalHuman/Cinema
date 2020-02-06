using Cinema.Scripts.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Cinema.Scripts.ViewModel
{
    public class TitlePageVM : INotifyPropertyChanged
    {//100-61 60-40 40-0

        #region Constructor

        public TitlePageVM()
        {
            TitleInfo = (TitleInfo)App.SearchPageVM.ResultTitles[App.SearchPageVM.SelectedIndex].Clone();
            new TitlesEdit().RemoveTitleNumber(TitleInfo);
            SetColors();
        }

        #endregion

        #region Properties

        #region SettingColors

        private void SetColors()
        {
            if (TitleInfo.Metascore != "N/A")
            {
                byte metascore = byte.Parse(TitleInfo.Metascore);
                if (metascore < 61 && metascore > 40)
                {
                    BackGround = Brushes.Yellow;
                    ForeGround = Brushes.Black;
                }
                else if (metascore < 40)
                {
                    BackGround = Brushes.Red;
                    ForeGround = Brushes.White;
                }
            }
            else
            {
                BackGround = Brushes.Transparent;
                ForeGround = Brushes.Transparent;
            }
        }

        #endregion

        #region MetaRatingForeground
        private Brush foreground = Brushes.White;
        public Brush ForeGround
        {
            get => foreground;
            set
            {
                foreground = value;
                OnPropertyChanged("Foreground");
            }
        }
        #endregion

        #region MetaRatingBackGround
        private Brush background = Brushes.Green;
        public Brush BackGround
        {
            get => background;
            set
            {
                background = value;
                OnPropertyChanged("Background");
            }
        }
        #endregion

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
