   M S B A M L   `   `   `  ����O  KNestleJARApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:NestleJARApplicationNestleJARApplication  5   	   %    NestleJARApplication.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:NestleJARApplication     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ��5
   
   �� 5       �� ImageSource$N HC:\Users\Andrew.Waszak\source\repos\NestleJar\NestleJar\UIBackground.jpg��6    j� Stretch$ UniformToFill=�6p   6�   .+�5   
   �� $
��Left=�6   $��	67,42,0,0q�6/   $��Nestle Project��6B   $
��Wrap=�6X   $	��Top=�6l   $��21��6�   $��86��6�   �� 5   
   $
��Left=�6   $��
400,45,0,0q�6/   $ ��Associate to Plant Project��6C   $
��Wrap=�6e   $	��Top=�6y   �� 5   
   -   5         ��Name$ projectField2��5       �� SelectedItem$ mySelectedItem��6)   $��555,42,31,272q�6H   �� 5   
   $
��Left=�6   $��
534,10,0,0q�6.   $/��)Drop Down avialable projects in plant SQL��6B    �� TextWrapping$
 Wrap=�6s   $	��Top=�6�   $	��256��6�   $��19��6�   �� 5   
   $
��Left=�6   $��	67,94,0,0q�6/   $$��Typical Fields of Project Info��6B   $
��Wrap=�6h   $	��Top=�6|   �� 5   
   -   5         ��Name$ sqlField��5      $
��Left=�6%   $��
67,115,0,0q�6@   $��TextBox��6T   $
 Wrap=�6c   $	��Top=�6w   $	��333��6�   $��85��6�   �� 5   
   -   5         ��Name$ importButton��5      $��Import��6'   $
��Left=�68   $��447,115,0,0q�6S   $	��Top=�6h   $��23��6�   $��87��6�   6�   �� 5   
   -   5        $ updateButton��5      $��Update��6'   $
��Left=�68   $��447,158,0,0q�6S   $	��Top=�6h   $��24��6�   $��87��6�   6�   �� 5   
   $
��Left=�6   $��
67,217,0,0q�6/   $��Bom Records:��6C   $
��Wrap=�6W   $	��Top=�6k   �� 5   
   -   5        $ testbox��5      $
��Left=�6$   $��
67,238,0,0q�6?   $��Listed like excel?��6S   $
 Wrap=�6m   $	��Top=�6�   $	��333��6�   $	��143��6�   �� 5   
   $
��Left=�6   $��405,238,0,0q�6/   $��Click to Edit��6D   $
��Wrap=�6Y   $	��Top=�6m   �� 5   
   -   5        $��Manual BOM Entry��5   &   $
��Left=�6A   $��542,311,0,0q�6\   $	��Top=�6q   $��41��6�   $	��162��6�   �� 5   
   -   5        $��Folder Explorer��5   )   $
��Left=�6C   $��
447,79,0,0q�6^   $	��Top=�6r   $��87��6�   �� 5   
   -   5        $ 	sqlTables��5      $ mySelectedItem��6%   $��555,208,31,144q�6D   5      5      