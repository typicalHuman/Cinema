using System;
using System.Collections.Generic;
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

        private TitleInfo ResultTitle { get; set; } = new TitleInfo();
        public TitleInfo GetFilm(string name)
        {
            string link = new Link().GetLink(name);
            xmlString = GetXMLString(link);
            SetResultTitle();
            return null;
        }

        #region Setters

        private void SetResultTitle()
        {
            SetTitle();
            SetYear();
            SetType();
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
                if (values[i].ToString().ToLower() == element)
                    return i;
            return -1;

        }

        private void SetType()
        {
            
            string s_type = SetterPattern(@"type="".*?""", @"""", "type=");
            int index  = GetEnumElementIndex(s_type, Enum.GetNames(typeof(TitleInfo.TitleTypes)));
            TitleInfo.TitleTypes[] values = (TitleInfo.TitleTypes[])Enum.GetValues(typeof(TitleInfo.TitleTypes));
            ResultTitle.Type = values[index];
        }
        private void SetYear()
        {
            ResultTitle.Year = int.Parse(SetterPattern(@"year="".*?""", @"""", "year="));
        }
        private void SetTitle()
        {
            ResultTitle.Title = ResultTitle.Title = SetterPattern(@"title="".*?""", "title=");
        }

        #endregion

        #region XML
        private string GetXMLString(string url)
        {
            WebClient web = new WebClient();
            return web.DownloadString(url);
        }
        #endregion

    }
}
