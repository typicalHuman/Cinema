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
        private string xmlString { get; set; }

        public string[] GetIDs(string name)
        {
            GlobalParse(name);
            return default(string[]);
        }

        private void GlobalParse(string name)
        {
            name.Replace(" ", "+");
            xmlString = new Parsing().GetXMLString($"https://www.imdb.com/find?q={name}&ref_=nv_sr_sm");
            EditXMLString();
            
        }

        private void EditXMLString()
        {
            
            xmlString = Regex.Match(xmlString, @"<div class=""findSection"">
<h3 class=""findSectionHeader""><a name =""tt""></a>Titles</h3>
<table class=""findList"">
<.*").Value;
        }
    }
}
