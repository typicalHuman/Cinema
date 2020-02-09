using Cinema.Scripts.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Cinema
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainVM MainVM { get; set; }
        public static SearchPageVM SearchPageVM { get; set; }
        public static FilterMenuPageVM FilterMenuPageVM { get; set; }
        public static WatchedListVM WatchedListVM { get; set; }
        public static TitlePageVM TitlePageVM { get; set; }
        public App()
        {
            MainVM = new MainVM();
            SearchPageVM = new SearchPageVM();
            FilterMenuPageVM = new FilterMenuPageVM();
            WatchedListVM = new WatchedListVM();
        }
    }
}
