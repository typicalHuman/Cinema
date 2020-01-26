using Cinema.Scripts.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using static Cinema.Scripts.Model.TitleInfo;

namespace Cinema.Scripts.ViewModel
{
    public class FilterMenuPageVM : INotifyPropertyChanged
    {
        #region Constructor
        public FilterMenuPageVM()
        {
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
                    Type = TitleTypes.Movie;
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
                    Type = TitleTypes.Series;
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
                    Type = TitleTypes.Movie;
                }));
            }
        }

        #endregion

        #region GenreCheck

        private TitleGenres[] allGenreValues = (TitleGenres[])Enum.GetValues(typeof(TitleGenres));

        private int GetItemIndex(TitleGenres genre)
        {
            for (int i = 0; i < Genres.Count; i++)
                if (genre == Genres[i])
                    return i;
            return -1;
        }

        private RelayCommand genreCheck;
        public RelayCommand GenreCheck
        {
            get
            {
                return genreCheck ?? (genreCheck = new RelayCommand(obj =>
                {
                    foreach (TitleGenres title in allGenreValues)
                        if (title.ToString() == obj.ToString())
                            App.FilterMenuPageVM.Genres.Add(title);

                }));
            }
        }

        private RelayCommand genreUncheck;
        public RelayCommand GenreUncheck
        {
            get
            {
                return genreUncheck ?? (genreUncheck = new RelayCommand(obj =>
                {
                    for (int i = 0; i < App.FilterMenuPageVM.allGenreValues.Length; i++)
                    {
                        TitleGenres genre = App.FilterMenuPageVM.allGenreValues[i];
                        if (genre.ToString() == obj.ToString())
                            App.FilterMenuPageVM.Genres.RemoveAt(GetItemIndex(genre));
                    }
                }));
            }
        }
        #endregion

        #endregion

        #region Properties 

        #region TitleGenresBoxes
        private List<TitleGenres> titleGenres = Enum.GetValues(typeof(TitleGenres)).OfType<TitleGenres>().ToList();
        public List<TitleGenres> TitleGenres
        {
            get => titleGenres;
            set
            {
                titleGenres = value;
                OnPropertyChanged("titleGenres");
            }
        }
        #endregion

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

        #region Genres

        private ObservableCollection<TitleGenres> genres = new ObservableCollection<TitleGenres>();
        public ObservableCollection<TitleGenres> Genres
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

        private TitleTypes type;
        public TitleTypes Type
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
