   M S B A M L   `   `   `  ����C  ?Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HospitalHospital  5   	        Hospital.ChequeAdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Hospital     5   	     � Title$  ChequeAdminWindow��5   	   $	��450��6#   $	��800��60   $	��450��6<   $	��500��6L   $	��800��6\   $	��850��6k   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��207* �6   �� 5      $
��239* �6   �� 5      $
��202* �6   �� 5      $
��153* �6    � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��20* �6   �� 5      $	��10* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
ChequeGrid��5      $	��217��6'   $��Center=�64   $��4��6~      CanUserAddRows .  6�   �� 5   
   -   5         ��Name$ ChequeCreateBt��5      $��
10,10,10,0q�6)   $/��)Добавить пользователя��6=   $��16(�6]   $��2��6k   $��42��6�   $	��Top=�6�   �� 5   
   -   5        $ ChequeDeleteBt��5      $��	5,10,10,0q�6)   $-��'Удалить пользователя��6<   $��16(�6[   $	��Top=�6i   $��2��6�   $��2��6�   $��42��6�   �� 5   
   -   5        $ ChequeBackBt��5      $��
20,10,20,0q�6'   $��
Назад��6;   $��16(�6K   $��42��6Y   $	��Top=�6e   $��2��6}   $��3��6�   $��Center=�6�   �� 5   
   -   5        $ ChequeUpdateBt��5      $��
22,10,22,0q�6)   $/��)Изменить пользователя��6=   $��16(�6]   $	��Top=�6k   $��2��6�   $��1��6�   $��42��6�   �� 5   
   -   5         ��Name$ ChequePaymentComboBox��5      $��31,81,31,36q�62   $��1��6G   $��1��6T   �� 5   
   $��15(�6   $��
31,56,31,0q�6"   $	��Top=�66   $��24��6N   $��1��6Z   $��1��6g   $/��)Выберете метод оплаты:��6w   �� 5   
   -   5        $ ChequeUsersComboBox��5      $��20,80,20,37q�60   $��1��6E   �� 5   
   $��15(�6   $��
20,56,21,0q�6"   $	��Top=�66   $��24��6N   $��1��6Z   $0��*Выберете пользователя:��6g   5      5      