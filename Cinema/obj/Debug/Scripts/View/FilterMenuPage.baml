   M S B A M L   `   `   `  ����A  =Cinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CinemaCinema  5      '    !Cinema.Scripts.View.FlterMenuPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Cinema     5      U QMaterialDesignThemes.Wpf, Version=3.1.0.945, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5        N� Title$  FlterMenuPage��5
       N� 
Foreground
 ����� N� 
FontFamily$ Courier New)�60    N� FontSize$ 22(�5         
Cinema.App   FilterMenuPageVM � DataContext# Z 6   .��5      � ���#1b1c1b.+�5   
   �� .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� .+�5      �� $��Year Interval:��6    $	��5 5q�66   $��24(�5       $��	UltraBold"�6.   �� 5      $ 
Horizontal=�6!   .+�5      �� -   5        )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 From��5   "   .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 �����	 �� 
CaretBrush
	 �����$	��5 0q�5   -   ���#F2E5D7
 �� 	MaxLength$
 4��5   0   $��50��6>   ��5      �� *Year1+ �� UpdateSourceTrigger$ PropertyChanged=��� 5      -   5        $��1��5   "   $ To��62   
 �����
	 �����$	��5 0q�5   -   ���#F2E5D7$
 4��5   0   $��50��6>   ��5!      �� *Year2+$ PropertyChanged=�5"      5#      �� 5'      $
��10 0q�6   .+�5(      �� $��Title Type:��6    $	��0 5q�63   $��24(�5)       $��	UltraBold"�6.   �� 5*      .+�5+      �� $	��0 5q�6#    (  $MaterialDesignUserForegroundCheckBox#��[  5,       d� 	IsChecked 5-       �� *	IsMovie+.��6?   Movie.  (System.Windows.Interactivity.Interaction   Triggers 5/      /  )System.Windows.Interactivity.EventTrigger  50   "      	EventName$ Checked��61   .  (System.Windows.Interactivity.TriggerBase   Actions. 51   &   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6<   �� *
MovieCheck+52   #     53   "   $ 	Unchecked��61   . 54   &      6<   �� *	UnCheck+55   #   57      �� 58      $	��0 5q�6$   #��[  59       5:      �� *
IsSeries+.��6>   Series 5<        5=   "   $ Checked��61   . 5>   &      6<   �� *SeriesCheck+5?   #     5@   "   $ 	Unchecked��61   . 5A   &      6<   �� *	UnCheck+5B   #   5D      5E      5F      5H      �� 5I      $��Genres:��6   $��5 20 0 0q�6'   $��24(�69   $��	UltraBold"�6G   �� 5J      $ 
Horizontal=�6   5�     �� 5�     ��6   �� *TitleGenres+��5�     �� 5�     .R�5�     A�  A� Columns$ 2��6&   5�     ��5�     �� 5�     .R�5�     �� $ 
Horizontal=�6%   $��5 5 0 0q�6>   .+�5�     �� # Z 6'   #��[  5�  '    5�  "     5�  &   $ Checked��65   . 5�  *      6@   �� *
GenreCheck+   CommandParameter 5�  4   ��  �� ElementName$ Genre�� �� Path$
 Text�5�  '     5�  &   $ 	Unchecked��65   . 5�  *      6@   �� *GenreUncheck+ 5�  4   �� $ Genre��$
 Text�5�  '   5�     �� 5�     $��Genre��6L   
���������6;   �� 6L   5�     5�     5�     5�     5�     5�     