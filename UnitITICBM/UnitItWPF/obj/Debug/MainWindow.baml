   M S B A M L   `   `   `  ����D  @UnitItWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:UnitItWPF.MVVM.ViewModelUnitItWPF.MVVM.ViewModel  5   	   %clr-namespace:UnitItWPF	UnitItWPF  5   	       UnitItWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <	viewModel&clr-namespace:UnitItWPF.MVVM.ViewModel     5   	   )localclr-namespace:UnitItWPF     5   	   -   5          �Name$  UnitIT_CMDB��5   	    � Title$ UnitIT CMDB��5	   	   $	��600��6   $	��920��6*    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � Icon$ Images/UIT.png��5   #    � DataContext 5      ,  &UnitItWPF.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      	 � RowDefinitions	 5      �� 5      $��75 �6    �� 5      .+�5       �� $��1��6   .+�5!      	� $
��Home��6   $��50��5"      
�������$��14(�5$         MenuButtonTheme#��[  5%      
 d� 	IsChecked$

 TrueY�5&      ��5'      �� *HomeViewCommand+	� 5*      $��Customer��6   $��50��5+      
�������$��14(�5-      #��[  5.      ��5/      �� *CustomerViewCommand+	� 52      $��Network��6   $��50��53      
�������$��14(�55      #��[  56      	� 59      $��	Component��6   $��50��5:      
�������$��14(�5<      #��[  5=      ��5>      �� *ComponentViewCommand+5B      �� 5D      $	��250��6   $��40��5E      $��Center=�5F      $
��Left=�5G      $��5q�5H      $��1��5I        ModernTextbox#��[ 5J      �� 5L      $��1��6   $��1��5M      $��10q�5N      ��5O      �� *CurrentView+�� 5P      $
��Left=�6   $��60��6/   $��	10,10,0,0q�6;   $	��Top=�6N   $	��180��6f   $��/images/unit-it-logo.png��6r   5R      5V      5W      