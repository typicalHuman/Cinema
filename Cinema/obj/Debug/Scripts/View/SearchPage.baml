   M S B A M L   `   `   `  ����A  =Cinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CinemaCinema  5      C&clr-namespace:Cinema.Scripts.ViewModelCinema.Scripts.ViewModel  5      9!clr-namespace:Cinema.Scripts.ViewCinema.Scripts.View  5      $    Cinema.Scripts.View.SearchPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Cinema     5      5vm&clr-namespace:Cinema.Scripts.ViewModel     5      2view!clr-namespace:Cinema.Scripts.View     5      U QMaterialDesignThemes.Wpf, Version=3.1.0.945, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
        N� 
FontFamily$  Courier New)�5       N� FontSize$ 20(�61    N� 
Foreground
 ����� N� Title$ 
SearchPage��5         
Cinema.App   SearchPageVM � DataContext# Z 6   .��5      � -   5        $��
searchPage��5       ���#1b1c1b.+�5   
   $   Cinema.Scripts.View.TitlesList     ItemsSource 6   �� *ResultTitles+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��Center=�6   $��Center=�62   {�5      �� *IsSearching+$ PropertyChanged=���5      �� 5       �� 
TargetType" ��6   	 �� Triggers	 5      �� 5      
 �� Binding
 6&   �� *Text+ �� ElementName$ 
statusText�� �� Value Nothing found6W   .a�5      ��  �� Property � y� �� Value$ Visible=�6;   5      ^� 5       ^� 
Conditions 5      �� 5   "    �� Binding 6,   �� *Text+$ 
statusText�� �� Value 	Searching6]   �� 5   "    6,   ��  �� RelativeSource ��  �� Mode$
 Self=� �� Path$ 	IsEnabled�	 False6z   0�5       �� 5!   "    � y�$ Hidden=�6?   5#      ^� 5$       5%      �� 5&   "    6,   �� *Text+$ 
statusText�� 	Searching6]   �� 5'   "    6,   ��  �� $
 Self=�$ 	IsEnabled� True6z   0�5)      �� 5*   "    � y�$ Visible=�6?   5,      5.      .+�50      �� {�6   �� *IsSearching+$ PropertyChanged=�.+�51      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Loading=�6*   $��50��69   $��50��6D   $��Center=�52   "   
�������{�53   &   �� *IsSearching+$ PropertyChanged=�z�54      �� 55      -   5        
rotate�� �� CenterX$ 25Q�56       �� CenterY$ 25Q�57       � Triggers 59      :� 5:       :� RoutedEvent$ Loaded��6'   .[�5;      �� .��5<   "   ��  g� RepeatBehavior$ Forever��6-   .��5=   &   W�  �� 
TargetName$ rotate��66    �� TargetProperty$ Angle�5>   &   	 W� By$	 360X�5?   &    g� Duration$ 0:0:1D�6/   5@   #   5A      5B      5D      ��5E      �� 5F      " ��6   	 5G      �� 5H      
 6*   ��  �� $
 Self=�$ 	IsEnabled� True6x   .a�5I   "   ��  � y�$ Visible=�6?   5J      �� 5K      
 6*   ��  �� $
 Self=�$ 	IsEnabled�	 False6x   .a�5L   "   ��  � y�$ Hidden=�6?   5M      5O      5Q      �� 5T      -   5        $��
statusText��5U      
���������5T      �� *
StatusText+$ PropertyChanged=�5U      5V      �� 5X   
   $��Search Results��6   $��Center=�6*   
�������$��Center=�6\   y�5Y      �� *StatusVisibility+$ PropertyChanged=�5]      5^      