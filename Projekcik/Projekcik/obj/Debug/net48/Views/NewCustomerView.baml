   M S B A M L   `   `   `  ����D  @Projekcik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Projekcik.ViewsProjekcik.Views  5      %    Projekcik.Views.NewCustomerView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Projekcik.Views     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Imię:��6   $��0,8,0,8q�6    $��0��61   $��0��6A   $��Center=�6N   $��Center=�6r   $��50��6�   �� 5   
   $��1��6   $��0��6"   $
��Left=�6/   $��Center=�6J   $	��100��6e   
���   ���6q   ��  �� Path$ 	FirstName� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��6�   �� 5   
   $��	Nazwisko:��6   $��0,8,0,8q�6$   $��0��65   $��1��6E   $��Center=�6R   $��Center=�6v   �� 5   
   $��1��6   $��1��6"   $
��Left=�6/   $��Center=�6J   $	��100��6e   
���   ���6q   �� $ LastName�$ PropertyChanged=�$
 True��6�   �� 5   
   $��Email��6   $��0,8,0,8q�6    $��0��61   $��2��6A   $��Center=�6N   $��Center=�6r   �� 5   
   $��1��6   $��2��6"   $
��Left=�6/   $��Center=�6J   $	��100��6e   
���   ���6q   �� $ Email�$ PropertyChanged=�$
 True��6�   �� 5!   
   $
��Kraj��6   $��0,8,0,8q�6   $��0��60   $��3��6@   $��Center=�6M   $��Center=�6q   �� 5"   
   $��1��6   $��3��6"   $
��Left=�6/   $��Center=�6J   $	��100��6e   
���   ���6q   �� $ Country�$ PropertyChanged=�$
 True��6�   �� 5$   
   $��Miasto:��6   $��0,8,0,8q�6"   $��0��63   $��4��6C   $��Center=�6P   $��Center=�6t   �� 5%   
   $��1��6   $��4��6"   $
��Left=�6/   $��Center=�6J   $	��100��6e   
���   ���6q   �� $
 City�$ PropertyChanged=�$
 True��6�   �� 5(   
   $��Ulica:��6   $��0,8,0,8q�6!   $��0��62   $��5��6B   $��Center=�6O   $��Center=�6s   �� 5)   
   $��1��6   $��5��6"   $
��Left=�6/   $��Center=�6J   $	��120��6e   
���   ���6q   �� $ 
StreetName�$ PropertyChanged=� �� Mode$ TwoWay=�$
 True��6�   �� 5+   
   $��Numer lokalu��6   $��0,8,0,8q�6'   $��0��68   $��6��6H   $��Center=�6U   $��Center=�6y   �� 5,   
   $��1��6   $��6��6"   $
��Left=�6/   $��Center=�6J   $	��120��6e   
���   ���6q   �� $ Numer�$ PropertyChanged=�$ TwoWay=�$
 True��6�   �� 5.   
   $��Status adresu:��6   $��0,8,0,8q�6)   $��0��6:   $��7��6J   $��Center=�6W   $��Center=�6{   �� 5/   
   $��1��6   $��7��6#   $��0,8,0,8q�60   $
��left=�6A   $	��120��6\    �� DisplayMemberPath$ Value��50   F    �� SelectedValuePath$	 Key��6`   
���   ���6   �� *AdressStatusComboBoxItems+ �� SelectedValue 6x   �� $ stat_id�$ PropertyChanged=�$ TwoWay=�6�   �� 52   
   $��Dodaj��6   $	��100��6!   $
��Left=�6-   ��6H   �� *SaveAndCloseCommand+54      55      