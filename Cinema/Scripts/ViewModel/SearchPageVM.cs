using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Cinema.Scripts.Model;

namespace Cinema.Scripts.ViewModel
{
    public class SearchPageVM : INotifyPropertyChanged
    {

        #region Constructor
        public SearchPageVM()
        {
            IsMenuClosed = App.MainVM.IsMenuClosed;
            ResultTitles = new List<TitleInfo>();
        }
        #endregion


        #region Commands
        #region NavigateTitleCommand
        private RelayCommand navigateTitleCommand;
        public RelayCommand NavigateTitleCommand
        {
            get
            {
                return navigateTitleCommand ?? (navigateTitleCommand = new RelayCommand(obj =>
                {

                    int dotIndex = obj.ToString().IndexOf('.');
                    if (dotIndex > -1 && dotIndex < 4)// for dots in name
                    {
                        int titleNumber = int.Parse(obj.ToString().Remove(dotIndex));
                        TitleInfo title = null;
                        if (App.MainVM.lastPage.Contains("Search"))
                             title = App.SearchPageVM.ResultTitles[titleNumber - 1];
                        else
                            title = App.WatchedListVM.WatchedTitles[titleNumber - 1];
                        App.TitlePageVM = new TitlePageVM(title);
                        App.MainVM.Navigate("Scripts/View/TitlePage.xaml");
                    }

                }));
            }
        }

        #endregion
        #endregion


        #region Properties

        #region SelectedIndex
        public int SelectedIndex { get; set; }

        #endregion

        #region ResultTitles
        private List<TitleInfo> resultTitles;
        public List<TitleInfo> ResultTitles
        {
            get
            {
                return resultTitles;
            }
            set
            {
                resultTitles = value;
                OnPropertyChanged("ResultTitles");
            }
        }

        #endregion

        #region IsSearching

        private bool isSearching;
        public bool IsSearching
        {
            get => isSearching;
            set
            {
                isSearching = value;
                OnPropertyChanged("IsSearching");
            }
        }

        #endregion

        #region IsMenuClosed
        private bool isMenuClosed;
        public bool IsMenuClosed
        {
            get => isMenuClosed;
            set
            {
                isMenuClosed = value;
                OnPropertyChanged("IsMenuClosed");
            }
        }
        #endregion

        #region StatusText
        private string statusText = "Searching";
        public string StatusText
        {
            get => statusText;
            set
            {
                statusText = value;
                OnPropertyChanged("StatusText");
            }
        }
        #endregion

        #region StatusVisibility

        private Visibility statusVisibility = Visibility.Visible;
        public Visibility StatusVisibility
        {
            get => statusVisibility;
            set
            {
                statusVisibility = value;
                OnPropertyChanged("StatusVisibility");
            }
        }

        #endregion


        #region 



        #endregion

        #region OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

        #endregion
    }
}