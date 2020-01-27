using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cinema.Scripts.Model
{
    public class Parsing
    {
        private string xmlString { get; set; }

        private ObservableCollection<TitleInfo> ResultTitles  { get; set; } = new ObservableCollection<TitleInfo>();
        public ObservableCollection<TitleInfo> GetFilms(string name)
        {
            new GlobalSearch().GetIDs(name);
            SetResultTitle();
            return ResultTitles;
        }

        #region Setters
        private void SetResultTitle()
        {
            for(int i = 0; i < ResultTitles.Count; i++)
            {
                ResultTitles.Add(new TitleInfo());
                SetTitle(ResultTitles[i]);
                SetYear(ResultTitles[i]);
                SetType(ResultTitles[i]);
                SetGenre(ResultTitles[i]);
                SetPlot(ResultTitles[i]);
                SetDirector(ResultTitles[i]);
                SetWriter(ResultTitles[i]);
                SetActors(ResultTitles[i]);
                SetPoster(ResultTitles[i]);
                SetMetascore(ResultTitles[i]);
                SetImdbRating(ResultTitles[i]);
                SetImdbVotes(ResultTitles[i]);
            }

        }
        private string SetterPattern(string pattern, params string[] toDelete)
        {
            string val = Regex.Match(xmlString, pattern).Groups[0].Value;
            for(int i = 0; i < toDelete.Length; i++)
               val = val.Replace(toDelete[i], "");
            return val.Replace(@"""", "");
        }
        private int GetEnumElementIndex(string element, string[] values)
        {
            for (int i = 0; i < values.Length; i++)
                if (values[i].ToString().ToLower() == element.ToLower())
                    return i;
            return -1;

        }


        private void SetImdbVotes(TitleInfo ResultTitle)
        {
            ResultTitle.ImdbVotes = SetterPattern(@"imdbVotes="".*?""", "imdbVotes=", @"""");
        }
        private void SetImdbRating(TitleInfo ResultTitle)
        {
            ResultTitle.ImdbRating= SetterPattern(@"imdbRating="".*?""", @"""", "imdbRating=").Replace('.', ',');
        }
        private void SetMetascore(TitleInfo ResultTitle)
        {
            ResultTitle.Metascore = SetterPattern(@"metascore="".*?""", @"""", "metascore=");
        } 
        private void SetPoster(TitleInfo ResultTitle)
        {
            ResultTitle.Poster = SetterPattern(@"poster="".*?""", "poster=", @"""");
        }
        private void SetActors(TitleInfo ResultTitle)
        {
            ResultTitle.Actors = SetterPattern(@"actors="".*?""", "actors=", @"""");
        }
        private void SetWriter(TitleInfo ResultTitle)
        {
            ResultTitle.Writer = SetterPattern(@"writer="".*?""", "writer=", @"""");
        }
        private void SetDirector(TitleInfo ResultTitle)
        {
            ResultTitle.Director = SetterPattern(@"director="".*?""", "director=", @"""");
        }
        private void SetPlot(TitleInfo ResultTitle)
        {
            ResultTitle.Plot = SetterPattern(@"plot="".*?""", "plot=");
        }
        private void SetGenre(TitleInfo ResultTitle)
        {
            string s_genre = SetterPattern(@"genre="".*?""", @"""", "genre=", @"""");
            s_genre = s_genre.Replace(" ", "");
            string[] s_genres = s_genre.Split(',');
            for(int i = 0; i < s_genres.Length; i++)
            {
                int index = GetEnumElementIndex(s_genres[i], Enum.GetNames(typeof(TitleInfo.TitleGenres)));
                TitleInfo.TitleGenres[] values = (TitleInfo.TitleGenres[])Enum.GetValues(typeof(TitleInfo.TitleGenres));
                ResultTitle.Genres.Add(values[index]);
            }
        }
        private void SetType(TitleInfo ResultTitle)
        {
            
            string s_type = SetterPattern(@"type="".*?""", @"""", "type=");
            int index  = GetEnumElementIndex(s_type, Enum.GetNames(typeof(TitleInfo.TitleTypes)));
            TitleInfo.TitleTypes[] values = (TitleInfo.TitleTypes[])Enum.GetValues(typeof(TitleInfo.TitleTypes));
            ResultTitle.Type = values[index];
        }
        private void SetYear(TitleInfo ResultTitle)
        {
            ResultTitle.Year = SetterPattern(@"year="".*?""", @"""", "year=");
        }
        private void SetTitle(TitleInfo ResultTitle)
        {
            ResultTitle.Title = SetterPattern(@"title="".*?""", "title=");
        }

        #endregion
        #region XML
        public string GetXMLString(string url)
        {
            WebClient web = new WebClient();
            return web.DownloadString(url);
        }
        #endregion
    }
}
