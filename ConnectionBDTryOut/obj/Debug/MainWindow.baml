   M S B A M L   `   `   `  ����M  IConnectionBDTryOut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ConnectionBDTryOutConnectionBDTryOut  5   	   #    ConnectionBDTryOut.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ConnectionBDTryOut     5   	     � Title$  Students��5   	   $	��450��6   $	��684��6'   .��5	      � -   5         � ColumnDefinitions 5
   
   �� 5      $	��250 �6   �� 5      $
��650* �6   .+�5   
   �� $��1��6   .+�5      �� -   5        $��StudentList��5      $	��300��6)    �� Left$ 14��66   
 �� Top$ 96��6G   $	��220��6W   6c   �� 5      $��ID��6   $ 30��6!   $ 67��62   �� 5      $��	Full Name��6   $	 106��6(   $ 67��6:    J� RenderTransformOrigin$ 0.28,1&�6J   5      �� 5   
   $��ID��6   $��1��6   $
��Left=�6-   $��
36,142,0,0q�6H   $	��Top=�6\   �� 5   
   $��
First Name��6   $��1��6%   $
��Left=�65   $��
38,191,0,0q�6P   $	��Top=�6d   �� 5   
   $��	Last name��6   $��1��6$   $
��Left=�64   $��
38,240,0,0q�6O   $	��Top=�6c   �� 5   
   -   5         ��Name$ IDText��5      $��1��6"   $
��Left=�62   $��22��6M   $��122,144,0,0q�6Y    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5   
   -   5        $ FirstNameText��5      $��1��6)   $
��Left=�69   $��22��6T   $��124,194,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��238��6�   �� 5   
   -   5        $ LastNameText��5      $��1��6(   $
��Left=�68   $��23��6S   $��126,243,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��236��6�   �� 5   
   -   5        $��InsertButton��5      $��Insert��6%   $��1��66   $
��Left=�6F   $��
44,294,0,0q�6a   $	��Top=�6u   $��80��6�   $��30��6�   6�   �� 5   
   -   5        $��UpdateButton��5      $��Update��6%   $��1��66   $
��Left=�6F   $��165,294,0,0q�6a   $	��Top=�6v   $��80��6�   $��30��6�   {�.  6�   �� 5   
   -   5        $��DeleteButton��5      $��Delete��6%   $��1��66   $
��Left=�6F   $��278,294,0,0q�6a   $	��Top=�6v   $��80��6�   $��30��6�   {�.  6�   5      5      