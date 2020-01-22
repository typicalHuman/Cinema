using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Scripts.Model
{
    public class TitleInfo : INotifyPropertyChanged
    {
        #region Properties

        #region Title
        private string title;
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        #endregion

        #region Year
        private int year;
        public int Year
        {
            get => year;
            set
            {
                year = value;
                OnPropertyChanged("Year");
            }
        }
        #endregion

        #region Type
        public enum TitleTypes
        {
            Movie, Series
        }

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

        #region Genre
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

        #endregion

        #region Plot
        private string plot;
        public string Plot
        {
            get => plot;
            set
            {
                plot = value;
                OnPropertyChanged("Plot");
            }
        }
        #endregion

        #region Director
        private string director;
        public string Director
        {
            get => director;
            set
            {
                director = value;
                OnPropertyChanged("Director");
            }
        }
        #endregion

        #region Writer
        private string writer;
        public string Writer
        {
            get => writer;
            set
            {
                writer = value;
                OnPropertyChanged("Writer");
            }
        }
        #endregion

        #region Actors

        private string actors;
        public string Actors
        {
            get => actors;
            set
            {
                actors = value;
                OnPropertyChanged("Actors");
            }
        }
        #endregion

        #region Poster
        private string poster;
        public string Poster
        {
            get => poster;
            set
            {
                poster = value;
                OnPropertyChanged("Poster");
            }
        }

        #endregion

        #region Metascore
        private byte metascore;
        public byte Metascore
        {
            get => metascore;
            set
            {
                metascore = value;
                OnPropertyChanged("Metascore");
            }
        }

        #endregion

        #region IMDbRating
        private float imdbRating;
        public float ImdbRating
        {
            get => imdbRating;
            set
            {
                imdbRating = value;
                OnPropertyChanged("ImdbRating");
            }
        }
        #endregion

        #region IMDbVotes
        private string imdbVotes;
        public string ImdbVotes
        {
            get => imdbVotes;
            set
            {
                imdbVotes = value;
                OnPropertyChanged("ImdbVotes");
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
