   M S B A M L   `   `   `  ����A  =Cinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CinemaCinema  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      #    Cinema.Scripts.View.TitlePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Cinema     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      U QMaterialDesignThemes.Wpf, Version=3.1.0.945, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      3system&clr-namespace:System;assembly=mscorlib  5        N� 
FontFamily$  Courier New)�5
       N� FontSize$ 20(�6     N� 
Foreground
 ����� N� Title$ 	TitlePage��5         
Cinema.App   TitlePageVM � DataContext# Z 6   .��5      � ���#1b1c1b � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $
��Left=�6   $��2��60   $
��5 10q�5   %   $	��120��63   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��    MainVM# Z 6   $��50��6C   $��50��6O   $	��Top=�5         MaximizeButtonStyle#��[  61   $��5q�5      	 � ToolTip$	 Back to list��6$   ��5      0  *MaterialDesignThemes.Wpf.PackIconExtension  
   Kind$
 KeyboardReturn=�   Size$ 20X�.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5         	EventName$ Click��6)   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 64   �� *PageNavigateCommand+   CommandParameter 5   ,   �� *
lastPage+5       5"      �� 5#      $
��Wrap=�6>   $	��390��6R   $	��5 0q�6a   $��30(�5$      $��Center=�6+   $
��Bold"�5%      ��5#      �� *TitleInfo.Title+5%      �� 5&      $��Center=�6<   
�������$
��Left=�5'   C   $��50��5(   ,   $	��5 0q�6:   ��5&      �� *TitleInfo.Year+5(   :   5)      �� 5-      $ 
Horizontal=�6   .+�5.      �� $	��196��6<   $	��134��5/   $   $��UniformToFill=�60   $	��Top=�50   (   $	��5 0q�6@   ��5.      �� *TitleInfo.Poster+50   @   �� 51      .+�53      �� $ 
Horizontal=�6!   .+�54      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Star=�62   
��� ���$��40��55   2   $��40��6>   $��20(�6I   �� 56      .+�57      �� $ 
Horizontal=�6)   .+�58   "   �� 
�������$��Center=�59   ;   $	��5 0q�5:   $   $
��Bold"�61   ��58   ,   �� *TitleInfo.ImdbRating+5:   1   �� 5;   "   $	��/10��6,   
�������$��Center=�6N   $��15(�5<   $   5=      �� 5>      $��15(�5?       
�������$	��5 0q�6E   ��5>   )   �� *TitleInfo.ImdbVotes+5?   E   5@      �� 5A      $��40��6!   $��40��6,   {�.  #��[  5B   I   $	��5 0q�5D   !   ��5B   !   �� *TitleInfo.Metascore+��6v   �� *
ForeGround+��5C   !   �� *
BackGround+5D   !   5E      �� 5H      $	��450��6H   $
��Wrap=�5I   0   $	��5 5q�6D   $��17(�5J   0   $
��Left=�6>   ��5H       �� *TitleInfo.GenresString+5J   >   �� 5K      $	��400��6@   $��15(�5L   0   
�������$
��Wrap=�5M   0   $	��5 0q�6D   $
��Left=�6Q   ��5K       �� *TitleInfo.Plot+5M   Q   �� 5N      $	��400��6D   $
��Wrap=�6S   $	��5 5q�5O       $
��Left=�6-   ��5N       �� *TitleInfo.Director+5O   -   5P      5Q      �� 5S      $	��600��6[   $
��Left=�6j   $
��Wrap=�5T       $	��5 5q�64   $��Oblique$�6A   ��5S      ��  �� StringFormat$ Actors: {0}�� �� Path$ TitleInfo.Actors�5T   A   �� 5U      $	��600��5V      $
��Wrap=�6'   $	��5 5q�6;   ��5U      �� $ Writers: {0}��$ TitleInfo.Writer�5V   ;   5W      d� 5Z   
   $��60��6   $��60��6"   $��Right=�6.   $��1��6J   $	��Top=�5[   )     AddButtonStyle#��[ 6A   $��5q�5]       d� 	IsChecked 5\      �� *TitleInfo.IsAdded+ 5^        5_      $ Checked��6!   . 5`         6,   �� *
AddTitle+ 5a   ,   �� *	TitleInfo+5b        5c      $ 	Unchecked��6!   . 5d         6,   �� *RemoveTitle+ 5e   ,   �� *	TitleInfo+5f      5h      5j      5k      