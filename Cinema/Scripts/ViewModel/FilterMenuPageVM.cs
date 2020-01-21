using Cinema.Scripts.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Cinema.Scripts.Model.BoxGenres;

namespace Cinema.Scripts.ViewModel
{
    public class FilterMenuPageVM : INotifyPropertyChanged
    {
        #region Constructor

        public FilterMenuPageVM()
        {
            BoxGenres1 = new ObservableCollection<BoxGenres>();
            BoxGenres2 = new ObservableCollection<BoxGenres>();
            Genres = new ObservableCollection<BoxGenres>();
            SetBoxesGenres();
        }

        #endregion

        #region Commands

        #region MovieCheck

        private RelayCommand movieCheck;
        public RelayCommand MovieCheck
        {
            get
            {
                return movieCheck ?? (movieCheck = new RelayCommand(obj =>
                {
                    IsSeries = false;
                    IsMovie = true;
                    Type = TitleType.Movie;
                }));
            }
        }
        #endregion

        #region SeriesCheck

        private RelayCommand seriesCheck;
        public RelayCommand SeriesCheck
        {
            get
            {
                return seriesCheck ?? (seriesCheck = new RelayCommand(obj =>
                {
                    IsSeries = true;
                    IsMovie = false;
                    Type = TitleType.Series;
                }));
            }
        }
        #endregion

        #region UnChecked
        private RelayCommand unCheck;
        public RelayCommand UnCheck
        {
            get
            {
                return unCheck ?? (unCheck = new RelayCommand(obj =>
                {
                    IsMovie = false;
                    IsSeries = false;
                    Type = TitleType.Movie;
                }));
            }
        }

        #endregion


        #endregion

        #region Properties 

        #region IsSeries
        private bool isSeries;
        public bool IsSeries
        {
            get => isSeries;
            set
            {
                isSeries = value;
                OnPropertyChanged("IsSeries");
            }
        }

        #endregion

        #region IsMovie
        private bool isMovie;
        public bool IsMovie
        {
            get => isMovie;
            set
            {
                isMovie = value;
                OnPropertyChanged("IsMovie");
            }
        }

        #endregion

        #region BoxGenres

        public TitleGenres[] allGenreValues { get; set; }

        private void SetBoxesGenres()
        {
            allGenreValues = (TitleGenres[])Enum.GetValues(typeof(TitleGenres));
            int i;
            for (i = 0; i < 13; i++)
                BoxGenres1.Add(new BoxGenres() { Genre = allGenreValues[i] });
            for (int k = i; k < allGenreValues.Length; k++)
                BoxGenres2.Add(new BoxGenres() { Genre = allGenreValues[k] });
        }



        private ObservableCollection<BoxGenres> boxGenres1;
        public ObservableCollection<BoxGenres> BoxGenres1
        {
            get => boxGenres1;
            set
            {
                boxGenres1 = value;
                OnPropertyChanged("BoxGenres1");
            }
        }

        private ObservableCollection<BoxGenres> boxGenres2;
        public ObservableCollection<BoxGenres> BoxGenres2
        {
            get => boxGenres2;
            set
            {
                boxGenres2 = value;
                OnPropertyChanged("BoxGenres2");
            }
        }
        #endregion

        #region Genres

        private ObservableCollection<BoxGenres> genres;
        public ObservableCollection<BoxGenres> Genres
        {
            get => genres;
            set
            {
                genres = value;
                OnPropertyChanged("Genres");
            }
        }


        #endregion

        #region TitleType
        public enum TitleType
        {
            Movie, Series
        }

        private TitleType type;
        public TitleType Type
        {
            get => type;
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }

        #endregion

        #region YearInterval

        public string YearInterval
        {
            get => year1 + "-" + year2;
        }

        private string year2;
        public string Year2
        {
            get => year2;
            set
            {
                year2 = value;
                OnPropertyChanged("Year2");
            }
        }

        private string year1;
        public string Year1
        {
            get => year1;
            set
            {
                year1 = value;
                OnPropertyChanged("Year1");
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
