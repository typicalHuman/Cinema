   M S B A M L   `   `   `  ����A  =Cinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CinemaCinema  5      $    Cinema.Scripts.View.TitlesList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Cinema     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      -   5        $��	TitleList��5       
�������$��20(�5
   !   $��Courier New)�6/   .��5      � .+�5   
   �� $��Disabled=�6   $
��Auto=�6@   .��5      �� $��Stretch=�5      ��5      �� *ItemsSource+  �� ElementName$  	TitleList�� �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5      .R�5      �� $
��Left=�6%   $
��5 10q�5   %   $	��120��63   .+�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $��98��6B   $��67��5   $   $��UniformToFill=�6/   $	��Top=�5   (   ��5   (   �� *Poster+5   (   �� 5   "   .+�5   &   ]� .+�5   *   �� $��TitleBox��5   4   $y�	Collapsed=�5   4   ��6K   �� *Title+5   4   �� 5   *   �� 5   .   $��TitlePage.xaml?�68      
Cinema.App   SearchPageVM � DataContext# Z 6U   ���#136cb2.�5   N   .�5   2   �� $
��Wrap=�6m   $	��400��5   <   $	��5 0q�6K   $	��Top=�5    ,   $
��Left=�6D   ��5   <   �� $  TitleBox�� �� Path$
 Text�5    D   .  (System.Windows.Interactivity.Interaction   Triggers 5!   2   /  )System.Windows.Interactivity.EventTrigger  5"   6      	EventName$ RequestNavigate��6E   .  (System.Windows.Interactivity.TriggerBase   Actions. 5#   :   6  0System.Windows.Interactivity.InvokeCommandAction  	   Command	 6P   �� *NavigateTitleCommand+
   CommandParameter
 5$   P   �� $  TitleBox��$
 Text�5%   ;   5&   7   .�5'   J   5(   /   5)   +   �� 5*   *   $	��Top=�6J   
�������$
��Left=�5+   C   $��50��5,   ,   $	��5 0q�6:   ��5*   4   �� *Year+5,   :   5-   '   �� 5.   &   $	��450��6N   $
��Wrap=�5/   0   $	��5 0q�6D   $��17(�50   0   $
��Left=�6>   ��5.   0   �� *GenresString+50   >   �� 51   &   $	��400��6F   $��15(�52   0   
�������$
��Wrap=�53   0   $	��5 0q�6D   $
��Left=�6Q   ��51   0   �� *Plot+53   Q   54   #   55      56      57      59      5:      5;      5<      