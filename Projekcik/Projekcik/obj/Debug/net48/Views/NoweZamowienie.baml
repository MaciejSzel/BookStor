   M S B A M L   `   `   `  ����D  @Projekcik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Projekcik.ViewsProjekcik.Views  5      $    Projekcik.Views.NoweZamowienie   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Projekcik.Views     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� 
���������6   ��  �� Path$ 
CustomerId� �� UpdateSourceTrigger$ PropertyChanged=�6Y   �� 5   
   $��Imię:��6   $��0,8,0,8q�6    $��0��61   $��0��6A   $
��Left=�6N   $��Center=�6p   �� 5   
   $��0��6   $��0��6"   $��Center=�6/   $��Center=�6L   $	��100��6g   ${�False��6s   
���   ���6�   �� $ 	FirstName�$ PropertyChanged=�6�   �� 5   
   $��	Nazwisko:��6   $��0,8,0,8q�6$   $��0��65   $��1��6E   $
��Left=�6R   $��Center=�6t   �� 5   
   $��0��6   $��1��6"   $��Center=�6/   $��Center=�6L   $	��100��6g   ${�False��6s   
���   ���6�   �� $ LastName�$ PropertyChanged=�6�   �� 5    
   $��Email��6   $��0,8,0,8q�6    $��0��61   $��2��6A   $
��Left=�6N   $��Center=�6p   �� 5!   
   $��0��6   $��2��6"   $��Center=�6/   $��Center=�6L   $	��100��6g   ${�False��6s   
���   ���6�   �� $ Email�$ PropertyChanged=�6�   �� 5#   
   $
��Kraj��6   $��0,8,0,8q�6   $��0��60   $��3��6@   $
��Left=�6M   $��Center=�6o   �� 5$   
   $��0��6   $��3��6"   $��Center=�6/   $��Center=�6L   $	��100��6g   ${�False��6s   
���   ���6�   �� $ Country�$ PropertyChanged=�6�   �� 5&   
   $��Miasto:��6   $��0,8,0,8q�6"   $��0��63   $��4��6C   $
��Left=�6P   $��Center=�6r   �� 5'   
   $��0��6   $��4��6"   $��Center=�6/   $��Center=�6L   $	��100��6g   ${�False��6s   
���   ���6�   �� $
 City�$ PropertyChanged=�6�   �� 5*   
   $��Ulica:��6   $��0,8,0,8q�6!   $��0��62   $��5��6B   $
��Left=�6O   ${�False��6q   $��Center=�6�   �� 5+   
   $��0��6   $��5��6"   $��Center=�6/   $��Center=�6L   $	��120��6g   ${�False��6s   
���   ���6�   �� $ 
StreetName�$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5-   
   $��Numer lokalu��6   $��0,8,0,8q�6'   $��0��68   $��6��6H   $
��Left=�6U   $��Center=�6w   �� 5.   
   $��0��6   $��6��6"   $��Center=�6/   $��Center=�6L   $	��120��6g   ${�False��6s   
���   ���6�   �� $ Numer�$ PropertyChanged=�$ TwoWay=�6�   �� 50   
   $��30��6   $	��...��6   $��0��6*   $��0��6:   $��Right=�6G   $	��Top=�6c   ��6{   �� *ShowCustomersCommand+�� 53   
   $��Metoda wysyłki��6   $��0��6)   $��1��66   $
��Left=�6F   �� 54   
   $��1��6   $��0��6#   $��0,8,0,8q�60   $
��left=�6A   $	��120��6\    �� DisplayMemberPath$ Value��55   H    �� SelectedValuePath$	 Key��6b   
���   ���6   �� *ShippingMethodComboBoxItems+ �� SelectedValue 6z   �� $ lang_id�$ PropertyChanged=�$ TwoWay=�6�   �� 56   
   $��Koszt wysyłki��6   $��0��6(   $��1��65   $
��Left=�6E   $��Bottom=�6`   �� 57   
   $��2��6   $��0��6   $��1��6)   $
��Left=�69   $��Bottom=�6T   $��	100,0,0,0q�6o   �� 59   
   $��Data zamówienia��6   $��0��6*   $��1��67   $��Center=�6G   �� 5:   
   $��0��63   $��1��6@   $��Center=�6P   $��Center=�6m   ��6   �� $ 	OrderDate�6m   �� 5<   
   $��Status zamówienia��6   $��0��6,   $��1��69   $��Right=�6I   �� 5=   
   $��0��6   $��1��6    $��Right=�60   $��Center=�6L   $	��120��6g   $ Value��6�   $	 Key��6�   
���   ���6t   �� *OrderStatusComboBoxItems+ 6�   �� $ orderstatus.status_id�$ PropertyChanged=�$ TwoWay=�6>  �� 5?   
   $l��fZe względu na regulamin naszej księgarni jedna osoba można zamówić jedną książkę miesięcznie��6   $
��Wrap=�6x   $��1��6�   $��1��6�   $��Center=�6�   $��Center=�6�   
���   �6�   �� 5@   
   $��Wybierz książkę��6   $��1��6+   $��2��6;   ��6I   �� *ShowBookCommand+�� 5B   
   $��Tytuł:��6   $��0,8,0,8q�6!   $��1��62   $��3��6B   $
��Left=�6O   $	��Top=�6q   �� 5C   
   $��1��6   $��3��6"   $��Center=�6/   $	��Top=�6L   $	��100��6d   ${�False��6p   
���   ���6�   �� $ Title�$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��6�   �� 5E   
   $��Język:��6   $��0,8,0,8q�6!   $��1��62   $��3��6B   $
��Left=�6O   $��Bottom=�6q   �� 5F   
   $��1��6   $��3��6"   $��Center=�6/   $��Bottom=�6L   $	��100��6g   ${�False��6s   
���   ���6�   �� $ LanguageName�$ PropertyChanged=�$
 True��6�   �� 5H   
   $��Data wydania:��6   $��0,8,0,8q�6(   $��1��69   $��4��6I   $
��Left=�6V   $	��Top=�6x   (  "System.Windows.Controls.DatePicker  5I   
   $��1��6   $��4��6%   $��Center=�63   $	��Top=�6P   $	��100��6h   ${�False��6t   
���   �	   SelectedDate	 6�   �� $ PublicationDate�$ PropertyChanged=�6�   �� 5K   
   $��Autor:��6   $��0,8,0,8q�6!   $��1��62   $��4��6B   $
��Left=�6O   $��Bottom=�6q   �� 5L   
   $��1��6   $��4��6"   $��Center=�6/   $��Bottom=�6L   $	��120��6g   ${�False��6s   
���   ���6�   �� $ Author�$ PropertyChanged=�$ TwoWay=�6�   �� 5N   
   $��Cena:��6   $��5��6    $��1��6-   $��Center=�6=   $	��Top=�6Z   $��25(�6r   �� 5P   
   $��5��6a   $��1��6n   $��Center=�6~   $��Bottom=�6�   $��25(�6�   ��6   �� $ Price�$ PropertyChanged=�$ TwoWay=�6�   �� 5R   
   $��Dodaj zamowienie��6   $��1��6,   $��6��6<   ��6I   �� *SaveAndCloseCommand+5X      5Y      