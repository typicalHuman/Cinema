   M S B A M L   `   `   `  ����A  =Cinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Cinema.Scripts.StylesCinema.Scripts.Styles  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089U QMaterialDesignThemes.Wpf, Version=3.1.0.945, Culture=neutral, PublicKeyToken=null   AddButtonStyle  �� 
TargetType  MaximizeButtonStyle �� BasedOn �� Triggers ^� 
Conditions �� Binding �� RelativeSource �� Mode �� Path �� Value	 �� Property
 �� Value0   *MaterialDesignThemes.Wpf.PackIconExtension    Kind    Size�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      -local#clr-namespace:Cinema.Scripts.Styles  5      FmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      %=  &	        7  �� 5      "  d�6#   8    5   
   ^� 5       5      �� 5	       6    ��  �� $
 Self=�$ 	IsChecked�	 False6n   0�5      �� 5      	 � ��
 60      $ BookmarkAdd=�$ 23X��� 5      	 �@�ToolTip$
 Add to watched list��60   5      ^� 5       5      �� 5       6    ��  �� $
 Self=�$ 	IsChecked� True6n   0�5      �� 5      	 � ��
 60      $ MarkerCheck=�$ 23X��� 5      	 �@�ToolTip$
 Remove from watched list��60   5      5      5      