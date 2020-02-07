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

        public void Edit(List<TitleInfo> titles)
        {
            UseFilter(titles);
            for(int i = 0; i < titles.Count; i++)
            {
                int temp = i;
                ChangeEmptyPoster(titles, ref i);
                if (temp == i)
                {
                    SetTitlesNumber(titles[i], i);
                    SetYear(titles[i]);
                    ChangeEmptyPlot(titles[i]);
                    SetGenresString(titles[i]);
                }  
            }

        }

        public void RemoveTitleNumber(TitleInfo title)
        {
            string _title = title.Title;
            string toRemove = _title.Remove(_title.IndexOf('.') + 1);
            title.Title = title.Title.Replace(toRemove, "");
        }

        private void UseFilter(List<TitleInfo> titles)
        {
            if (App.FilterMenuPageVM == null)
                App.FilterMenuPageVM = new ViewModel.FilterMenuPageVM();
            for (int i = 0; i < titles.Count; i++)
            {
                if (!CheckGenres(titles[i]) || !YearCheck(titles[i]) || !TypeCheck(titles[i]))
                {
                    titles.RemoveAt(i);
                    i--;
                }
            }
        }

        private bool TypeCheck(TitleInfo title)
        {
            return title.Type == App.FilterMenuPageVM.Type;
        }

        private bool YearCheck(TitleInfo title)
        {
            int startYear, endYear, titleYear = -1;
            if (App.FilterMenuPageVM.Year2 == "" || App.FilterMenuPageVM.Year2 == null)
                endYear = 9999;
            else
                endYear = int.Parse(App.FilterMenuPageVM.Year2);
            if (App.FilterMenuPageVM.Year1 == "" || App.FilterMenuPageVM.Year1 == null)
                startYear = 0;
            else
                startYear = int.Parse(App.FilterMenuPageVM.Year1);
            bool isParse = int.TryParse(title.Year, out titleYear);
            if (isParse)
                titleYear = int.Parse(title.Year);
            return titleYear >= startYear && titleYear <= endYear;
        }

        private bool CheckGenres(TitleInfo title)
        {
            for (int k = 0; k < title.Genres.Count; k++)
            {
                if (!App.FilterMenuPageVM.Genres.Contains(title.Genres[k]) && App.FilterMenuPageVM.Genres.Count != 0)
                    return false;
            }
            return true;
        }

        private void ChangeEmptyPoster(List<TitleInfo> titles, ref int i)
        {
            if (titles[i].Poster == "N/A")
                titles[i].Poster = "pack://application:,,,/Materials/noneTitle.png";
            if (titles[i].Poster == "")
            {
                titles.RemoveAt(i);
                i--;
            }
        }

        public void SetTitlesNumber(TitleInfo title, int i)
        {
            title.Title = $"{i + 1}.{title.Title}";
        }

        private void SetYear(TitleInfo title)
        { 
            title.Year = $"({title.Year})";
        }

        private void ChangeEmptyPlot(TitleInfo title)
        {
            if (title.Plot == "N/A")
                title.Plot = "";
        }

        private void SetGenresString(TitleInfo title)
        {
            for (int k = 0; k < title.Genres.Count; k++)
                if (k != title.Genres.Count - 1)
                    title.GenresString += $"{title.Genres[k].ToString()} | ";
                else
                    title.GenresString += title.Genres[k].ToString();
        }
    }
}