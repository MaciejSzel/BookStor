   M S B A M L   `   `   `  ����D  @Projekcik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Projekcik.ViewsProjekcik.Views  5      #    Projekcik.Views.NowaKsiążka   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Projekcik.Views     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Tytuł:��6   $��0,8,0,8q�6!   $��0��62   $��0��6B   $��Center=�6O   $��Center=�6s   $��50��6�   �� 5   
   $��1��6   $��0��6"   $
��Left=�6/   $��Center=�6J   $	��100��6e   
���   ���6q   ��  �� Path$ Title� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��6�   �� 5   
   $��Language Code:��6   $��0,8,0,8q�6)   $��0��6:   $��1��6J   $��Center=�6W   $��Center=�6{   �� 5   
   $��1��6   $��1��6#   $��0,8,0,8q�60   $
��left=�6A   $	��120��6\    �� DisplayMemberPath$ Value��5   F    �� SelectedValuePath$	 Key��6`   
���   ���6   �� *LanguageCodeComboBoxItems+ �� SelectedValue 6x   �� $ lang_id�$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5   
   $��Język:��6   $��0,8,0,8q�6!   $��0��62   $��2��6B   $��Center=�6O   $��Center=�6s   �� 5    
   $��1��6   $��2��6"   $
��Left=�6/   $��Center=�6J   $	��100��6e   
���   ���6q   �� $ LanguageName�$ PropertyChanged=�$
 True��6�   �� 5"      $��Liczba stron:��6   $��0,8,0,8q�6)   $��0��6:   $��3��6J   $��Center=�6W   $��Center=�6{   �� 5#   
   $��1��6   $��3��6"   $
��Left=�6/   $��Center=�6J   $	��100��6e   
���   ���6q   �� $ Pages�$ PropertyChanged=�6�   �� 5%   
   $��Data wydania:��6   $��0,8,0,8q�6(   $��0��69   $��4��6I   $��Center=�6V   $��Center=�6z   (  "System.Windows.Controls.DatePicker  5&   
   $��1��6   $��4��6%   $
��left=�63   $	��100��6N   
���   �	   SelectedDate	 6Z   �� $ PublicationDate�$ PropertyChanged=�6�   �� 5(   
   $��Wydawca:��6   $��0,8,0,8q�6#   $��0��64   $��5��6D   $��Center=�6Q   $��Center=�6u   �� 5)   
   $��1��6   $��5��6"   $
��Left=�6/   $��Center=�6J   $	��120��6e   
���   ���6q   �� $ PublisherName�$ PropertyChanged=�$ TwoWay=�$
 True��6�   �� 5+   
   $��Cena:��6   $��0,8,0,8q�6    $��0��61   $��6��6A   $��Center=�6N   $��Center=�6r   �� 5,   
   $��1��6   $��6��6"   $
��Left=�6/   $��Center=�6J   $	��120��6e   
���   ���6q   �� $
 Cena�$ PropertyChanged=�$ TwoWay=�$
 True��6�   �� 5.   
   $��Autor:��6   $��0,8,0,8q�6!   $��0��62   $��7��6B   $��Center=�6O   $��Center=�6s   �� 5/   
   $��1��6   $��7��6"   $
��Left=�6/   $��Center=�6J   $	��120��6e   ${�False��6q   
���   ���6�   �� $ 
AuthorName�$ PropertyChanged=�$ TwoWay=�6�   �� 51   
   $	��...��6   $��1��6   $��7��6/   $��30��6<   $��Right=�6G   ��6c   �� *ShowAutorzy+�� 53   
   $��Dodaj��6   $	��100��6!   $
��Left=�6-   ��6H   �� *SaveAndCloseCommand+55      56      