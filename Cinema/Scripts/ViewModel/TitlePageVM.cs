using Cinema.Scripts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace Cinema.Scripts.ViewModel
{
    public class TitlePageVM : INotifyPropertyChanged
    {//100-61 60-40 40-0


        #region Constructor

        public TitlePageVM(TitleInfo title)
        {
            TitleInfo = (TitleInfo)title.Clone();
            TitleInfo.IsAdded = IsAdded(TitleInfo);
            new TitlesEdit().RemoveTitleNumber(TitleInfo);
            SetColors();
        }

        #endregion

        #region IsAdded

        private bool IsAdded(TitleInfo title)
        {
            TitleInfo clone = (TitleInfo)title.Clone();
            new TitlesEdit().RemoveTitleNumber(clone);
            for(int i = 0; i < App.WatchedListVM.WatchedTitles.Count; i++)
            {
                TitleInfo _title = (TitleInfo)App.WatchedListVM.WatchedTitles[i].Clone();
                new TitlesEdit().RemoveTitleNumber(_title);
                if (clone.Compare(_title))
                    return true;
            }
            return false;
        }

        #endregion

        #region Numbering

        private void Numbering()
        {
            for(int i = 0; i < App.WatchedListVM.WatchedTitles.Count; i++)
            {
                TitleInfo title = App.WatchedListVM.WatchedTitles[i];
                new TitlesEdit().RemoveTitleNumber(title);
                new TitlesEdit().SetTitlesNumber(title, i);
            }
        }

        #endregion

        #region Commands

        #region AddTitle

        private RelayCommand addTitle;
        public RelayCommand AddTitle
        {
            get
            {
                return addTitle ?? (addTitle = new RelayCommand(obj =>
                {
                    TitleInfo title = (TitleInfo)((TitleInfo)obj).Clone();
                    new TitlesEdit().SetTitlesNumber(title, App.SearchPageVM.SelectedIndex);
                    App.WatchedListVM.WatchedTitles.Insert(0, title);
                    TitleInfo.IsAdded = true;
                    Numbering();
                }));
            }
        }
        #endregion

        #region RemoveTitle
        private RelayCommand removeTitle;
        public RelayCommand RemoveTitle
        {
            get
            {
                return removeTitle ?? (removeTitle = new RelayCommand(obj =>
                {
                    for(int i = 0; i < App.WatchedListVM.WatchedTitles.Count; i++)
                    {
                        TitleInfo _title = (TitleInfo)TitleInfo.Clone();
                        new TitlesEdit().SetTitlesNumber(_title, i);
                        if (_title.Compare(App.WatchedListVM.WatchedTitles[i]))
                        {
                            App.WatchedListVM.WatchedTitles.RemoveAt(i);
                        }
                    }
                    Numbering();
                }));
            }
        }
        #endregion


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
