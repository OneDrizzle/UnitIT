   M S B A M L   `   `   `  ����D  @UnitItWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:UnitItWPF.MVVM.ViewUnitItWPF.MVVM.View  5      C&clr-namespace:UnitItWPF.MVVM.ViewModelUnitItWPF.MVVM.ViewModel  5	      &     UnitItWPF.MVVM.View.CustomerView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:UnitItWPF.MVVM.View     5      <	viewModel&clr-namespace:UnitItWPF.MVVM.ViewModel     5	      -   5          >�Name$  UnitIT_CMDB��5      .��5      ��  �� CornerRadius$ 20��5      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ #272537��6    � Offset$ 0Q�6/   � 5      $ #272537��6   $ 1Q�6/   5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5       �� $��Customer��6   $��Center=�5!      $
��Left=�5"      
�������$��22(�5$      $��20,0,0,0q�5%      &   System.Windows.Controls.DataGrid  5(      -   5          Name$ Datagrid_Customers��5)      
������ $��1��5+      $
��Left=�5,      $	��300��5-      $��	24,65,0,0q�5.      $��1��5/      $	��Top=�50      $	��535��51      	   AutoGenerateColumns	 . 
   SelectionMode$
 Single=�54       �� SelectedItem 55      �� *SelectedItem+�� 59      $��1��6   .+�5;      	� -   5         	�Name$ Vis_Customer_Button��5;      $��Show Customer��5<      $��50��5=      
�������
������ $��14(�5@         MenuButtonTheme#��[  5A       d� 	IsChecked$
 TrueY�5B      ��5C      �� *HomeViewCommand+5D      	� 5F      -   5        $ Ændre_Customer_Button��5F      $��Expand Customer��5G      $��50��5H      
�������$��14(�5J      #��[  5K      ��5L      �� *CustomerViewCommand+6F   	� 5N      -   5        $ Slet_Customer_Button��5N      $��Delete Customer��5O      $��50��5P      
�������$��14(�5R      #��[  5S      6G   5V      �� 5W      $	��250��6   $��Center=�5X      $
��Left=�5Y      $��220,12,0,23q�5Z        ModernTextbox#��[ 5[      $��1��6=   �� 5]      -   5         ��Name$ textbox_New_Customer��5]      $��1��5`      $
��Left=�5a      $��24��5b      $��	57,36,0,0q�5c      $��1��5d       �� TextWrapping$
 Wrap=�5e      $	��Top=�5f      $	��120��5g      ��5_      �� *Datagrid_Customers+ �� UpdateSourceTrigger$ PropertyChanged=�5g      �� 5i      $��New Customer : ��6   
�������$��1��5k      $
��Left=�5l      $��	67,10,0,0q�5m      $��1��5n      $	��Top=�5o      �� 5q      -   5         ��Name$ add_New_Customer_Button��5q      $	��Add��5r      $��1��5s      $
��Left=�5t      $��
182,36,0,0q�5u      $��1��5v      $	��Top=�5w      $��70��5x      $��20��5y      ��5{      �� 5|       �� 
TargetType" ��6    �� Triggers 5}      �� 5~       �� Binding 6*   �� *Text.Length+ �� ElementName$ textbox_New_Customer��$ PropertyChanged=� �� Value 06�   .a�5   "   ��  �� Property � {� �� Value .  6>   5�      5�      5�      5�      5�      5�      