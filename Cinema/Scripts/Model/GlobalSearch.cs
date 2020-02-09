using Cinema.Scripts.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Cinema.Scripts.Model
{
    public class GlobalSearch
    {
        private string htmlString { get; set; }

        public string[] GetIDs(string name)
        {
            GlobalParse(name);
            return GetLinks();
        }

        private void GlobalParse(string name)
        {
            if (name != null)
            {
                name.Replace(" ", "+");
                htmlString = new Parsing().GetHTMLString(new Link().GetGlobalLink(name));
                GetLinks();
            }
        }

        private string[] GetLinks()
        {
            if (htmlString != null)
            {
                Regex reg = new Regex("<a href=\"/title/tt.*?/?ref_=adv_li_i\"");

                MatchCollection matches = reg.Matches(htmlString);
                List<string> list = new List<string>();
                for (int i = 0; i < matches.Count; i++)
                {
                    list.Add(matches[i].Groups[0].Value);
                    list[i] = list[i].Replace("<a href=\"/title/", "");
                    list[i] = list[i].Replace("/?ref_=adv_li_i\"", "");
                }
                return list.ToArray();
            }
            return default;
        }
    }
}
