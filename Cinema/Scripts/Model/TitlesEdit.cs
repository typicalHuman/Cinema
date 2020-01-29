using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Scripts.Model
{
    class TitlesEdit
    {

        public void Edit(ObservableCollection<TitleInfo> titles)
        {
            for(int i = 0; i < titles.Count; i++)
            {
                int temp = i;
                ChangeEmptyPoster(titles, ref i);
                if (temp == i)
                {
                    SetTitlesNumber(titles, i);
                    SetYear(titles, i);
                }
            }

        }

        private void ChangeEmptyPoster(ObservableCollection<TitleInfo> titles, ref int i)
        {
            if (titles[i].Poster == "N/A")
                titles[i].Poster = "pack://application:,,,/Materials/noneTitle.png";
            if (titles[i].Poster == "")
            {
                titles.RemoveAt(i);
                i--;
            }
        }

        private void SetTitlesNumber(ObservableCollection<TitleInfo> titles, int i)
        {
            titles[i].Title = $"{i + 1}.{titles[i].Title}";
        }

        private void SetYear(ObservableCollection<TitleInfo> titles, int i)
        { 
            titles[i].Year = $"({titles[i].Year})";
        }
    }
}
