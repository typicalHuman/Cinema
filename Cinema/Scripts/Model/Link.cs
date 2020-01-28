using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Scripts.Model
{
    class Link
    {

        private const string ApiKey = "18e2ef3";
        public string GetLink(string name)
        {
            string link = "http://www.omdbapi.com/?t=";
            name = name.Replace(" ", "+");
            link += name;
            link += $"&r=xml&apikey={ApiKey}";
            return link;
        }

        public string GetLink(string name, string id)
        {
            return $"http://www.omdbapi.com/?r=xml&apikey={ApiKey}&i={id}";
        }

        public string GetGlobalLink(string name)
        {
            name = name.Replace(" ", "+");
            string link = $"https://www.imdb.com/search/title/?title={name}";
            return link;
        }
    }
}
