   M S B A M L   `   `   `  ����D  @Projekcik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Projekcik	Projekcik  5   	       Projekcik.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Projekcik     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Księgarnia��5	   	   $	��600��6   $
��1080��6)   
������� � 
ResizeMode$ NoResize=�6I    � WindowStartupLocation$ CenterScreen=�6_    � WindowStyle$
 None=�6�    � 	Resources 5       �� Source�� 5   
   $ MainWindowResources.xaml?�6   %     � Triggers 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOtwórzMenu��66   .[�5       ��    OtwórzMenu#��[  6   5!      :� 5"   
   $ ButtonBase.Click��6   $ ButtonZamknijMenu��66   .[�5#      ��   ZamknijMenu#��[ 6   5$      .��5'      � 
�������.+�5(   
   �� $��
200,30,0,0q�6!     WorkspacesTemplate#��[ 5*        MainHCCStyle#��[ 5+      ��5)      �� 	 �� Path$	 
Workspaces�5+      � 5.   
   $��70��6   $	��Top=�6   ���	#FF007EFF.+�5/      �� $��Unique Book Store��6   $��Center=�61   $��Center=�6N   $��25(�6i   �� 50      $��Center=�6   
 �� Orientation$
 
Horizontal=�64   $��Right=�6M   .+�51      �� $��Maciej Szelag��6   $��Center=�61   $��20(�6L   '  !MaterialDesignThemes.Wpf.PopupBox  52      $��Right=�6*   $��10q�6F      PlacementMode$ BottomAndAlignRightEdges=�6R      	StaysOpen$ False��6{      PopupContent. 53      �� $	��150��6!   .+�54      �� $��Konto��6!   �� 55      $��
Ustawienia��6!   ��67   �� *KsiążkiCommand+�� 56      �� 57      -   5         ��Name$ ZamknijAplikacje��57   !   $��Zamknij aplikacje��6;   6W   58      59      5;      5<      � 5=   
   -   5         �Name$ GridMenu��5=      $��40��6!   $
��Left=�6,   ���	#FF1844F3.+�5?      �� .+�5@      � $��70��6   
�������.+�5A      �� -   5        $ ButtonZamknijMenu��5A      $��35��68   $��40��6C   $	��Top=�6|   $��Right=�6�   $y�	Collapsed=�6�   ��6O   Z� ��6e   Z� .��5B      '  !MaterialDesignThemes.Wpf.PackIcon  ���	#FF1844F3   Kind$
 Menu=�6J   $��40��6V   5C      �� 5D      -   5        $ ButtonOtwórzMenu��5D      $��60��67   $��60��6B   $	��Top=�6{   $��Right=�6�   ��6N   Z� ��6d   Z� .��5E        ���	#FF1844F3$
 Menu=�6I   $��25��6U   5F      5G      �� 5H      ���	#FF007EFF.@�5I      ��   CommandsTemplate#��[ 5K      #��[ 5L      ��5J      �� $	 Commands�5L      5b      5c      5d      5e      5f      