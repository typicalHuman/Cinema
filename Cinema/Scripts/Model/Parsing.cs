using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cinema.Scripts.Model
{
    public class Parsing
    {
        public ObservableCollection<TitleInfo> ResultTitles { get; set; } = new ObservableCollection<TitleInfo>();
        public ObservableCollection<TitleInfo> GetFilms(string name)
        {
            SetResultTitle(name);
            return ResultTitles;
        }

        #region Setters
        private void SetResultTitle(string name)
        {
            Download(name);
        }

        private async void Download(string name)
        {
            string[] titleIDs = new GlobalSearch().GetIDs(name);

            List<Task<TitleInfo>> tasks = new List<Task<TitleInfo>>(); string link;
            for (int i = 0; i < titleIDs.Length; i++)
            {
                link = new Link().GetLink(name, titleIDs[i]);
                tasks.Add(Load(link));
            }
            await Task.WhenAll(tasks);
            for (int i = 0; i < tasks.Count; i++)
                ResultTitles.Add(tasks[i].Result);
            new TitlesEdit().Edit(ResultTitles);
            App.SearchPageVM.ResultTitles = ResultTitles;
        }

        TitleInfo GetTitle(string xml)
        {
            TitleInfo titleInfo = new TitleInfo();
            SetType(titleInfo, xml);
            SetGenre(titleInfo, xml);
            SetTitle(titleInfo, xml);
            SetYear(titleInfo, xml);
            SetPlot(titleInfo, xml);
            SetDirector(titleInfo, xml);
            SetWriter(titleInfo, xml);
            SetActors(titleInfo, xml);
            SetPoster(titleInfo, xml);
            SetMetascore(titleInfo, xml);
            SetImdbRating(titleInfo, xml);
            SetImdbVotes(titleInfo, xml);
            return titleInfo;
        }

        async Task<TitleInfo> Load(string uri)
        {
            using (var client = new HttpClient())
            {
                var res = await client.GetStringAsync(uri);
                return GetTitle(res);
            }
        }

        private string SetterPattern(string pattern, string xml, params string[] toDelete)
        {
            string val = Regex.Match(xml, pattern).Groups[0].Value;
            for (int i = 0; i < toDelete.Length; i++)
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


        private void SetImdbVotes(TitleInfo ResultTitle, string xml)
        {
            ResultTitle.ImdbVotes = SetterPattern(@"imdbVotes="".*?""", xml, "imdbVotes=", @"""");
        }
        private void SetImdbRating(TitleInfo ResultTitle, string xml)
        {
            ResultTitle.ImdbRating = SetterPattern(@"imdbRating="".*?""", xml, @"""", "imdbRating=").Replace('.', ',');
        }
        private void SetMetascore(TitleInfo ResultTitle, string xml)
        {
            ResultTitle.Metascore = SetterPattern(@"metascore="".*?""", xml, @"""", "metascore=");
        }
        private void SetPoster(TitleInfo ResultTitle, string xml)
        {
            ResultTitle.Poster = SetterPattern(@"poster="".*?""", xml, "poster=", @"""");
        }
        private void SetActors(TitleInfo ResultTitle, string xml)
        {
            ResultTitle.Actors = SetterPattern(@"actors="".*?""", xml, "actors=", @"""");
        }
        private void SetWriter(TitleInfo ResultTitle, string xml)
        {
            ResultTitle.Writer = SetterPattern(@"writer="".*?""", xml, "writer=", @"""");
        }
        private void SetDirector(TitleInfo ResultTitle, string xml)
        {
            ResultTitle.Director = SetterPattern(@"director="".*?""", xml, "director=", @"""");
        }
        private void SetPlot(TitleInfo ResultTitle, string xml)
        {
            ResultTitle.Plot = SetterPattern(@"plot="".*?""", xml, "plot=");
        }
        private void SetGenre(TitleInfo ResultTitle, string xml)
        {
            string s_genre = SetterPattern(@"genre="".*?""", xml, @"""", "genre=", @"""");
            s_genre = s_genre.Replace(" ", "");
            string[] s_genres = s_genre.Split(',');
            for (int i = 0; i < s_genres.Length; i++)
            {
                int index = GetEnumElementIndex(s_genres[i], Enum.GetNames(typeof(TitleInfo.TitleGenres)));
                if (index != -1)
                {
                    TitleInfo.TitleGenres[] values = (TitleInfo.TitleGenres[])Enum.GetValues(typeof(TitleInfo.TitleGenres));
                    ResultTitle.Genres.Add(values[index]);
                }
            }

        }
        private void SetType(TitleInfo ResultTitle, string xml)
        {

            string s_type = SetterPattern(@"type="".*?""", xml, @"""", "type=");
            int index = GetEnumElementIndex(s_type, Enum.GetNames(typeof(TitleInfo.TitleTypes)));
            if (index != -1)
            {
                TitleInfo.TitleTypes[] values = (TitleInfo.TitleTypes[])Enum.GetValues(typeof(TitleInfo.TitleTypes));
                ResultTitle.Type = values[index];
            }
        }
        private void SetYear(TitleInfo ResultTitle, string xml)
        {
            ResultTitle.Year = SetterPattern(@"year="".*?""", xml, @"""", "year=");
        }
        private void SetTitle(TitleInfo ResultTitle, string xml)
        {
            ResultTitle.Title = SetterPattern(@"title="".*?""", xml, "title=");
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
