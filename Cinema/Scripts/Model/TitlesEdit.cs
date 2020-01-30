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
                    ChangeEmptyPlot(titles, i);
                    SetGenresString(titles, i);
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

        private void ChangeEmptyPlot(ObservableCollection<TitleInfo> titles, int i)
        {
            if (titles[i].Plot == "N/A")
                titles[i].Plot = "";
        }

        private void SetGenresString(ObservableCollection<TitleInfo> titles, int i)
        {
            for (int k = 0; k < titles[i].Genres.Count; k++)
                if (k != titles[i].Genres.Count - 1)
                    titles[i].GenresString += $"{titles[i].Genres[k].ToString()} | ";
                else
                    titles[i].GenresString += titles[i].Genres[k].ToString();
        }
    }
}