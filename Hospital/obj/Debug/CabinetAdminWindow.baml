   M S B A M L   `   `   `  ����C  ?Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HospitalHospital  5   	   !    Hospital.CabinetAdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Hospital     5   	     � Title$  CabinetAdminWindow��5   	   $	��450��6$   $	��800��61   $	��450��6=   $	��500��6M   $	��800��6]   $	��850��6l   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��207* �6   �� 5      $
��224* �6   �� 5      $
��222* �6   �� 5      $
��147* �6    � RowDefinitions 5   
   �� 5      $
��263* �6   �� 5      $
��101* �6   �� 5      $	��70* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ CabinetGrid��5      $	��263��6(   $��Center=�65   $��4��6}      CanUserAddRows .  6�   �� 5   
   $��15(�6   $��0,22,0,0q�6"   $��1��64   $	��Top=�6A   $��24��6Y   $��Center=�6e   $1��+Введите номер кабинета:��6�   �� 5   
   -   5         ��Name$ CabinetCreate��5      $��
12,22,10,0q�6(   $��2��6<   $%��Добавить кабинет��6I   $��16(�6d   $	��Top=�6r   6�   �� 5   
   -   5         ��Name$ 
CabinetTxb��5      $��
15,46,17,0q�6&   $��1��6;   $	��Top=�6H   $��33��6`   �� 5   
   -   5        $ CabinetDeleteBt��5      $��	10,0,44,0q�6*   $��2��6=   $#��Удалить кабинет��6J   $��16(�6d   $��Center=�6r   $��2��6�   �� 5   
   -   5        $ CabinetBackBt��5      $��	18,0,10,0q�6(   $��
Назад��6;   $��16(�6K   $��25��6Y   $��Center=�6e   $��2��6�   $��3��6�   �� 5   
   -   5        $ CabitUpdateBt��5      $��
23,22,19,0q�6(   $��2��6<   $%��Изменить кабинет��6I   $��16(�6d   $	��Top=�6r   $��1��6�   �� 5   
   $��15(�6   $��	23,25,0,0q�6"   $��1��65   $	��Top=�6B   $��24��6Z   $
��Left=�6f   $*��$Выберете отделение:��6�   $��1��6�   $	��162��6�   �� 5   
   -   5         ��Name$ CabinetComboBox��5      $��
23,49,39,0q�6,   $��1��6@   $��28��6M   $	��Top=�6Y   $��1��6q   5      5      