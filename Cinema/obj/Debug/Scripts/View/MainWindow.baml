   M S B A M L   `   `   `  ����A  =Cinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CinemaCinema  5   	       Cinema.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Cinema     5   	   U QMaterialDesignThemes.Wpf, Version=3.1.0.945, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   -   5          � Title$  
MainWindow��5   	   $	��650��6   $	��650��6,   $	��650��5	   	   $	��650��6      
Cinema.App   MainVM � DataContext# Z 5   	    � WindowStyle$
 None=�5   	   ���#F2E5D7
�������$��Courier New)�5      $��25(�65    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode 5   	   �� *
ResizeMode+ � WindowState 5   	   �� *WindowState+��5   	   �� *WindowBorderThickness+ � 	Resources 5         OpenMenu �� TargetProperty	 �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame
 O� KeyTime O� Value  	CloseMenu��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $	 GridMenu��6a   .\�5        $
 0��6'   $ 51Q�63     5      $
 0:0:0.3��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $	 GridMenu��6a   .\�5        $
 0��6'   $	 200Q�63     5      $
 0:0:0.3��6'   $ 51Q�69   5       5!      5"       � Triggers 5#      :� 5$   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5%      �� #��[  6   5&      :� 5'   
   $ ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5(      �� #��[ 6   5)      '  !System.Windows.Shell.WindowChrome   WindowChrome 5+        5,   
      CaptionHeight$ 0Q�5-   	      ResizeBorderThickness$ 7q�5.   	   .��50      � ���#1b1c1b � ColumnDefinitions 53   
   �� 54      $��51 �6   �� 55      $��2* �6   �� 56      $��6* �6   �� 57      $��51 �6   �� 58      $��51 �6   �� 59      $��51 �6   �� 5:      $��51 �6    � RowDefinitions 5=   
   �� 5>      $��40 �6   �� 5?      $	��12* �6   .+�5F   
   �� $��6��6   $��51��6!   $��40��6,   $��5q�69   $��0q�5G      
������  � ToolTip$ Close��5H        CloseButtonStyle#��[ 5I      ��5H   !   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Close=�   Size$ 25X�.  (System.Windows.Interactivity.Interaction   Triggers 5J      /  )System.Windows.Interactivity.EventTrigger  5K         	EventName$ Click��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5L      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *CloseCommand+5M      5O      �� 5T   
   $��4��6   $��40��6!   $��51��6-   $ Minimize��5U        MaximizeButtonStyle#��[ 6$   ��5V        $ WindowMinimize=�$ 25X� 5W        5X      $ Click��6!   . 5Y         5Z      �� *MinimizeCommand+5[      5]      �� 5a   
   $��5��6   $��40��6!   $��51��6-   $ Maximize��5b      #��[ 6$   ��5c        $ WindowMaximize=�$ 25X� 5d        5e      $ Click��6!   . 5f         5g      �� *MaximizeCommand+5h      5j      �� 5p   
   
����������#1b1c1b$��1��6:   $��2��6J   $��27(�5q      $	��5 0q�6    ���#F2E5D7)	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Search IMDb��5r   (   .
  (MaterialDesignThemes.Wpf.TextFieldAssist 
  UnderlineBrush
 ����� �� 
CaretBrush
 ����� �� 	MaxLength$ 50��5u      {�5t   %   �� *IsMenuClosed+��5u   !   �� *
SearchText+ �� UpdateSourceTrigger$ PropertyChanged=�.��6b     J� InputBindings  5v      �� 5w      
! �� Key$! Enter��6   " �� CommandParameter$"" Scripts/View/SearchPage.xaml��5x      # �� Command# 5w   )   �� *SearchCommand+$ PropertyChanged=�5x      .��5z   %   5{      �� 5|   
   $��51��6   $��40��6   #��[ 6(   $��3��5~      $ Search��6%   $��1q�66   $	��Top=�6A   $��Right=�5      ��5}        $ Search=�$ 25X�{�5�      �� *IsMenuClosed+ 5�        5�      $ Click��6!   . 5�        $   CommandParameter$"$ Scripts/View/SearchPage.xaml��5�   ,    5�   ,   �� *SearchCommand+5�   ,   5�      5�      � 5�   
   -   5        $��GridMenu��5�      $��51��6   $
��Left=�6*   ���#282828$��0��5�      $��2��6   $��0��60   $��3��6=   % K� ZIndex$% 3��6Q   .+�5�      �� .+�5�      � $��40��6   
�������z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      .+�5�      �� -   5        $��ButtonOpenMenu��5�      $��40��63   $��51��6?   $��Center=�6J   $��Center=�5�       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 68   ���	#FF31577E��5�      Z� ��63   Z� y�5�      �� *OpenMenuVisibility+ 5�        5�      $ Click��6-   . 5�   "      68   �� *OpenSideCommand+5�      .��5�      '  !MaterialDesignThemes.Wpf.PackIcon  &   Kind$
& Menu=�62   $��25��6>   $��25��6I   5�      �� 5�      -   5        $��ButtonCloseMenu��5�   4   $��40��6   $��51��6)   $��Center=�5�      $��Center=�6:   #��[ 5�      ���	#FF31577E��5�      Z� ��63   Z� y�5�      �� *CloseMenuVisibility+ 5�        5�      $ Click��6-   . 5�   "      68   �� *CloseSideCommand+5�      .��5�        $& 	ArrowLeft=�62   $��25��6C   $��25��6N   5�      5�      �� 5�      ���	#FF5C99D6$��Disabled=�62   $��16(�5�      ' �� SelectedIndex' 6)   �� *SelectedIndex+.@�5�      �� $��40��6#   .��5�      �� ( �� Orientation$( 
Horizontal=�6%   .+�5�        $& MovieSearchOutline=�66   $��25��6P   $	��5 0q�6\   $��25��6i   $��Center=�5�   6   $��Center=�6S   �� 5�      $��Search��6(   $��Center=�66   $
��10 0q�6Q   5�       5�        5�      $ Selected��6-   . 5�   "     $"$ Scripts/View/SearchPage.xaml��5�   8    5�   8   �� *PageNavigateCommand+5�   8   5�      5�      �� 5�      $��40��6#   .��5�      �� $( 
Horizontal=�6%   .+�5�        $& 
FilterMenu=�66   $��25��6H   $	��5 0q�6T   $��25��6a   $��Center=�5�   6   $��Center=�6S   �� 5�      $��Filter Menu��6(   $��Center=�6;   $
��10 0q�6V   5�       5�        5�      $ Selected��6-   . 5�   "     $&$  Scripts/View/FilterMenuPage.xaml��5�   8    5�   8   �� *PageNavigateCommand+5�   8   5�      5�      �� 5�      $��40��6#   .��5�      �� $( 
Horizontal=�6%   .+�5�        $& 
Wunderlist=�66   $��25��6H   $	��5 0q�5�   7   $��25��6D   $��Center=�6O   $��Center=�6l   �� 5�      $��Watched List��6(   $��Center=�6<   $
��10 0q�5�   (   5�       5�        5�      $ Selected��6-   . 5�   "     $'$ !Scripts/View/WatchedListPage.xaml��5�   8    5�   8   �� *PageNavigateCommand+5�   8   5�      5�      �� 5�      $��40��6#   .��5�      �� $( 
Horizontal=�6%   .+�5�        $& OpenInBrowser=�66   $��25��6K   $��25��6W   $��Center=�6b   $��Center=�6   $	��5 0q�5�   6   �� 5�      $
��IMDb��6(   $��Center=�64   $
��10 0q�6O   5�       5�        5�      $ Selected��6-   . 5�   "     $($ "https://www.imdb.com/?ref_=nv_home��5�   8    5�   8   �� *
GotoSite+5�   8   5�      5�      �� 5�      $��40��6#   .��5�      �� $( 
Horizontal=�6%   .+�5�        $& Facebook=�66   $��25��6F   $��25��6R   $��Center=�6]   $��Center=�6z   $	��5 0q�5�   6   �� 5�      $��Facebook��6(   $��Center=�68   $
��10 0q�6S   5�       5�        5�      $ Selected��6-   . 5�   "     $#$ https://www.facebook.com/imdb��5�   8    5�   8   �� *
GotoSite+5�   8   5�      5�      �� 5�      $��40��6#   .��5�      �� $( 
Horizontal=�6%   .+�5�        $& 	Instagram=�66   $��25��6G   $��25��6S   $��Center=�6^   $��Center=�6{   $	��5 0q�5�   6   �� 5�      $��	Instagram��6(   $��Center=�69   $
��10 0q�6T   5�       5�        5      $ Selected��6-   . 5  "     $%$ https://www.instagram.com/imdb/��5  8    5  8   �� *
GotoSite+5  8   5     5     �� 5     $��40��6#   .��5     �� $( 
Horizontal=�6%   .+�5       $& Twitter=�66   $��25��6E   $��25��6Q   $��Center=�6\   $��Center=�6y   $	��5 0q�5	  6   �� 5
     $��Twitter��6(   $��Center=�67   $
��10 0q�6R   5      5       5     $ Selected��6-   . 5  "     $$ https://twitter.com/imdb��5  8    5  8   �� *
GotoSite+5  8   5     5     �� 5     $��40��6#   .��5     �� $( 
Horizontal=�6%   .+�5       $& Twitch=�66   $��25��6D   $��25��6P   $��Center=�6[   $��Center=�6x   $	��5 0q�5  6   �� 5     $��Twitch��6(   $��Center=�66   $
��10 0q�6Q   5      5       5     $ Selected��6-   . 5  "     $ $ https://www.twitch.tv/IMDb��5  8    5  8   �� *
GotoSite+5  8   5     5     �� 5      $��40��6#   .��5!     �� $( 
Horizontal=�6%   .+�5"       $& Youtube=�66   $��25��6E   $��25��6Q   $��Center=�6\   $��Center=�6y   $	��5 0q�5#  6   �� 5$     $��Youtube��6(   $��Center=�67   $
��10 0q�6R   5%      5&       5'     $ Selected��6-   . 5(  "     $#$ https://www.youtube.com/imdb/��5)  8    5(  8   �� *
GotoSite+5)  8   5*     5,     5-     5/     50      � 53  
   -   5        )  �Name$) Frame1��53  0   *  � NavigationUIVisibility$* Hidden=�6   +  � Source$+ SearchPage.xaml?�54     $��1��55     $��1��6   $��6��6-   6C   5:     5;     