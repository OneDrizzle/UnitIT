   M S B A M L   `   `   `  ����D  @UnitItWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:UnitItWPF.MVVM.ViewUnitItWPF.MVVM.View  5      C&clr-namespace:UnitItWPF.MVVM.ViewModelUnitItWPF.MVVM.ViewModel  5	      '    !UnitItWPF.MVVM.View.ComponentView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:UnitItWPF.MVVM.View     5      <	viewModel&clr-namespace:UnitItWPF.MVVM.ViewModel     5	      -   5          >�Name$  UnitIT_CMDB��5      .��5      ��  �� CornerRadius$ 20��5      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ #272537��6    � Offset$ 0Q�6/   � 5      $ #272537��6   $ 1Q�6/   5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5!      �� $��	Component��6   $��Center=�5"      $
��Left=�5#      
�������$��22(�5%      $��20,0,0,0q�5&      &   System.Windows.Controls.DataGrid  5)      -   5          Name$ Datagrid_Component��5*      
������ $��1��5,      $
��Left=�5-      $	��300��5.      $��	24,65,0,0q�5/      $��1��50      $	��Top=�51      $	��535��52      	   AutoGenerateColumns	 . 
   SelectionMode$
 Single=�55       �� SelectedItem 56      �� *SelectedItem+�� 5:      $��1��6   .+�5<      	� -   5         	�Name$ Vis_Komponent_Button��5<      $��Show Component��5=      $��50��5>      
�������
������ $��14(�5A         MenuButtonTheme#��[  5B       d� 	IsChecked$
 TrueY�5C      ��5D      �� *HomeViewCommand+5E      	� 5G      -   5        $ Ændre_Komponent_Button��5G      $��Expand Component��5H      $��50��5I      
�������$��14(�5K      #��[  5L      ��5M      �� *ComponentViewCommand+6G   	� 5O      -   5        $ Slet_Komponent_Button��5O      $��Delete Component��5P      $��50��5Q      
�������$��14(�5S      #��[  5T      6G   5W      �� 5Z      -   5         ��Name$ textbox_New_Component��5Z      $��1��5]      $
��Left=�5^      $��24��5_      $��	57,36,0,0q�5`      $��1��5a       �� TextWrapping$
 Wrap=�5b      $	��Top=�5c      $	��120��5d      ��5\      �� *Datagrid_Component+ �� UpdateSourceTrigger$ PropertyChanged=�5e      �� 5g      $��New Component : ��6   
�������$��1��5i      $
��Left=�5j      $��	67,10,0,0q�5k      $��1��5l      $	��Top=�5m      �� 5o      -   5         ��Name$ add_New_Component_Button��5o      $	��Add��5p      $��1��5q      $
��Left=�5r      $��
182,36,0,0q�5s      $��1��5t      $	��Top=�5u      $��70��5v      $��20��5w      ��5z      �� 5{       �� 
TargetType" ��6    �� Triggers 5|      �� 5}       �� Binding 6*   �� *Text.Length+ �� ElementName$ textbox_New_Customer��$ PropertyChanged=� �� Value 06�   .a�5~   "   ��  �� Property � {� �� Value .  6>   5�      5�      5�      5�      5�      5�      