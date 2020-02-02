using System;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using GalaSoft.MvvmLight.Messaging;
using System.Diagnostics;
using Cinema.Scripts.Model;
using System.Threading;
using System.Collections.ObjectModel;

namespace Cinema.Scripts.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        #region Constructor
        public MainVM()
        {
            WindowBorderThickness = new Thickness(1);
            ResizeMode = ResizeMode.CanResizeWithGrip;
            CloseMenuVisibility = Visibility.Collapsed;
            IsMenuClosed = true;
        }
        #endregion

        #region Commands

        #region NavigateCommands

        public void Navigate(string url)
        {
            Messenger.Default.Send<NavigateArgs>(new NavigateArgs(url));
        }

        private RelayCommand pageNavigateCommand;
        public RelayCommand PageNavigateCommand
        {
            get
            {
                return pageNavigateCommand ?? (pageNavigateCommand = new RelayCommand(obj =>
                {
                    Navigate(obj.ToString());
                }));
            }
        }
        #endregion

        #region CloseCommand
        public Action CloseAction { get; set; }
        private RelayCommand closeCommand;
        public RelayCommand CloseCommand
        {
            get => closeCommand ?? (closeCommand = new RelayCommand(obj =>
            {
                CloseAction();
            }));

        }
        #endregion

        #region MaximizeCommand
        private RelayCommand maximizeCommand;
        public RelayCommand MaximizeCommand
        {
            get => maximizeCommand ?? (maximizeCommand = new RelayCommand(obj =>
            {
                if (WindowState == WindowState.Normal)
                {
                    //setting border no style
                    WindowBorderThickness = new Thickness(0);
                    ResizeMode = ResizeMode.NoResize;
                    WindowState = WindowState.Maximized;
                }
                else
                {
                    //setting border to resize with grip
                    WindowBorderThickness = new Thickness(1);
                    ResizeMode = ResizeMode.CanResizeWithGrip;
                    WindowState = WindowState.Normal;
                }
            }));
        }
        #endregion

        #region MinimizeCommand
        private RelayCommand minimizeCommand;
        public RelayCommand MinimizeCommand
        {
            get => minimizeCommand ?? (minimizeCommand = new RelayCommand(obj =>
            {
                WindowState = WindowState.Minimized;
            }));
        }
        #endregion

        #region OpenSideMenuCommand
        private RelayCommand openSideCommand;
        public RelayCommand OpenSideCommand
        {
            get => openSideCommand ?? (openSideCommand = new RelayCommand(obj =>
                {
                    CloseMenuVisibility = Visibility.Visible;
                    OpenMenuVisibility = Visibility.Collapsed;
                    IsMenuClosed = false;
                }));
        }
        #endregion

        #region CloseSideMenuCommand
        private RelayCommand closeSideCommand;
        public RelayCommand CloseSideCommand
        {
            get => closeSideCommand ?? (closeSideCommand = new RelayCommand(obj =>
            {
                CloseMenuVisibility = Visibility.Collapsed;
                OpenMenuVisibility = Visibility.Visible;
                IsMenuClosed = true;
            }));


        }
        #endregion

        #region SearchCommand

        private RelayCommand searchCommand;
        public RelayCommand SearchCommand
        {
            get => searchCommand ?? (searchCommand = new RelayCommand(obj =>
            {
                Search(obj);
            }));
        }

        private async void Search(object obj)
        {
            SelectedIndex = 0;
            Navigate(obj.ToString());
            App.SearchPageVM.ResultTitles = new ObservableCollection<TitleInfo>();
            App.SearchPageVM.IsSearching = true;
            Task gettingFilms = Task.Run(() =>
            {
                new Parsing().GetFilms(SearchText);
            });
            await Task.WhenAll(gettingFilms);
            App.SearchPageVM.IsSearching = false;
        }

        #endregion

        #region GotoSite

        private RelayCommand gotoSite;
        public RelayCommand GotoSite
        {
            get
            {
                return gotoSite ?? (gotoSite = new RelayCommand(obj => 
                {
                    Process.Start("https://www.imdb.com/?ref_=nv_home");
                }));
            }
        }

        #endregion

        #endregion

        #region Properties

        #region SelectedIndex
        private int selectedIndex;
        public int SelectedIndex
        {
            get => selectedIndex;
            set
            {
                selectedIndex = value;
                OnPropertyChanged("SelectedIndex");
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

        #region OpenMenuVisibility
        private Visibility openMenuVisibility;
        public Visibility OpenMenuVisibility
        {
            get => openMenuVisibility;
            set
            {
                openMenuVisibility = value;
                OnPropertyChanged("OpenMenuVisibility");
            }
        }
        #endregion

        #region CloseMenuVisibility
        private Visibility closeMenuVisibility;
        public Visibility CloseMenuVisibility
        {
            get => closeMenuVisibility;
            set
            {
                closeMenuVisibility = value;
                OnPropertyChanged("CloseMenuVisibility");
            }
        }
        #endregion

        #region WindowState
        private WindowState windowState;
        public WindowState WindowState
        {
            get => windowState; 
            set
            {
                windowState = value;
                OnPropertyChanged("WindowState");
            }
        }
        #endregion

        #region ResizeMode
        private ResizeMode resizeMode;
        public ResizeMode ResizeMode
        {
            get => resizeMode; 
            set
            {
                resizeMode = value;
                OnPropertyChanged("ResizeMode");
            }
        }
        #endregion

        #region WindowBorderThickness
        private Thickness windowBorderThickness;
        public Thickness WindowBorderThickness
        {
            get => windowBorderThickness; 
            set
            {
                windowBorderThickness = value;
                OnPropertyChanged("WindowBorderThickness");
            }
        }
        #endregion

        #region SearchText

        private string searchText;
        public string SearchText
        {
            get => searchText;
            set
            {
                searchText = value;
                OnPropertyChanged("SearchText");
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
