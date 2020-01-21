using Cinema.Scripts.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Scripts.Model
{
    public class BoxGenres : INotifyPropertyChanged
    {
        private TitleGenres genre;
        public TitleGenres Genre
        {
            get => genre;
            set
            {
                genre = value;
                OnPropertyChanged("Genre");
            }
        }


        #region GenreCheck

        private RelayCommand genreCheck;
        public RelayCommand GenreCheck
        {
            get
            {
                return genreCheck ?? (genreCheck = new RelayCommand(obj =>
                {
                    foreach (TitleGenres title in App.FilterMenuPageVM.allGenreValues)
                        if (title.ToString() == obj.ToString())
                            App.FilterMenuPageVM.Genres.Add(new BoxGenres() { Genre = title });

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
                    for(int i = 0; i < App.FilterMenuPageVM.allGenreValues.Length; i++)
                    {
                        TitleGenres genre = App.FilterMenuPageVM.allGenreValues[i];
                        if (genre.ToString() == obj.ToString())
                            App.FilterMenuPageVM.Genres.RemoveAt(GetItemIndex(genre));
                    }


                }));
            }
        }

        private int GetItemIndex(TitleGenres genre)
        {
            for (int i = 0; i < App.FilterMenuPageVM.Genres.Count; i++)
                if (genre == App.FilterMenuPageVM.Genres[i].Genre)
                    return i;
            return -1;
        }
        #endregion

        public enum TitleGenres
        {
            Action, Adventure, Animation, Biography,
            Comedy, Crime, Documentary, Drama,
            Family, Fantasy, FilmNoir, GameShow,
            History, Horror, Music, Musical,
            Mystery, News, RealityTV, Romance,
            SciFi, Sport, TalkShow, Thriller,
            War, Western
        }

        #region OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

    }
}
