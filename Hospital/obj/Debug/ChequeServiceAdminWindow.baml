   M S B A M L   `   `   `  ����C  ?Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HospitalHospital  5   	   '    !Hospital.ChequeServiceAdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Hospital     5   	     � Title$  ChequeServiceAdminWindow��5   	   $	��450��6*   $	��800��67   $	��450��6C   $	��500��6S   $	��800��6c   $	��850��6r   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��207* �6   �� 5      $
��239* �6   �� 5      $
��202* �6   �� 5      $
��153* �6    � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��20* �6   �� 5      $	��10* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ChequeServiceGrid��5      $	��217��6.   $��Center=�6;   $��4��6�      CanUserAddRows .  6�   �� 5   
   -   5         ��Name$ ChequeServiceCreateBt��5      $��
10,10,10,0q�60   $��Добавить чек��6D   $��16(�6[   $��2��6i   $��42��6�   $	��Top=�6�   �� 5   
   -   5        $ ChequeServiceDeleteBt��5      $��	5,10,10,0q�60   $��Удалить чек��6C   $��16(�6Y   $	��Top=�6g   $��2��6   $��2��6�   $��42��6�   �� 5   
   -   5        $ ChequeServiceBackBt��5      $��
20,10,20,0q�6.   $��
Назад��6B   $��16(�6R   $��42��6`   $	��Top=�6l   $��2��6�   $��3��6�   $��Center=�6�   �� 5   
   -   5        $ ChequeServiceUpdateBt��5      $��
22,10,22,0q�60   $��Изменить чек��6D   $��16(�6[   $	��Top=�6i   $��2��6�   $��1��6�   $��42��6�   �� 5   
   -   5         ��Name$ ServiceComboBox��5      $��
31,81,31,0q�6,   $��1��6@   $��1��6M   $��28��6]   $	��Top=�6i   �� 5   
   $��15(�6   $��
31,56,31,0q�6"   $	��Top=�66   $��24��6N   $��1��6Z   $��1��6g   $$��Выберете услугу:��6w   �� 5   
   -   5        $ ChequeComboBox��5      $��
20,80,20,0q�6+   $��1��6?   $��28��6L   $	��Top=�6X   �� 5   
   $��15(�6   $��
20,56,21,0q�6"   $	��Top=�66   $��24��6N   $��1��6Z   $+��%Выберете номер чека:��6g   5      5      