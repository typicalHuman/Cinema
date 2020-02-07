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
    public class SearchPageVM: INotifyPropertyChanged
    {

        #region Constructor
        public SearchPageVM()
        {
            IsMenuClosed = App.MainVM.IsMenuClosed;
            ResultTitles = new List<TitleInfo>();
        }
        #endregion


        #region Commands
        #region TitleInfoCommand
        private RelayCommand navigateTitleCommand;
        public RelayCommand NavigateTitleCommand
        {
            get
            {
                return navigateTitleCommand ?? (navigateTitleCommand = new RelayCommand(obj => 
                {
                    int dotIndex = obj.ToString().IndexOf('.');
                    string parseNumber = obj.ToString().Remove(dotIndex);
                    SelectedIndex = int.Parse(parseNumber) - 1;
                    App.MainVM.Navigate(@"Scripts\View\TitlePage.xaml");
                    App.TitlePageVM = new TitlePageVM();
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
            get => resultTitles;
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

        #region 


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


//стиль для кнопки добавления(удалить / добавить), xml