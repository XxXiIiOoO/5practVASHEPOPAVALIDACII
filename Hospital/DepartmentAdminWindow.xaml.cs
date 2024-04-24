using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using Hospital.HospitalDataSetTableAdapters;

namespace Hospital
{
    public partial class DepartmentAdminWindow : Window
    {
        DepartmentTableAdapter department = new DepartmentTableAdapter();

        public DepartmentAdminWindow()
        {
            InitializeComponent();
            DepartmentGrid.ItemsSource = department.GetData();
        }

        private void DepartmentCreate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DepartmentTxb.Text) ||
                string.IsNullOrWhiteSpace(DepartmentFloorTxb.Text))
            {
                MessageBox.Show("Поля не могут быть пустыми");
            }
            else if (!IsPositiveInteger(DepartmentFloorTxb.Text))
            {
                MessageBox.Show("Этаж должен быть положительным числом");
            }
            else if (!IsValidDepartmentName(DepartmentTxb.Text))
            {
                MessageBox.Show("Название отделения должно содержать только буквы");
            }
            else
            {
                department.InsertQuery(DepartmentTxb.Text, DepartmentFloorTxb.Text);
                DepartmentGrid.ItemsSource = department.GetData();
            }
        }

        private void DepartmentUpdateBt_Click(object sender, RoutedEventArgs e)
        {
            if (!IsPositiveInteger(DepartmentFloorTxb.Text))
            {
                MessageBox.Show("Этаж должен быть положительным числом");
            }
            else if (!IsValidDepartmentName(DepartmentTxb.Text))
            {
                MessageBox.Show("Название отделения должно содержать только буквы");
            }
            else if (string.IsNullOrWhiteSpace(DepartmentTxb.Text) ||
                     string.IsNullOrWhiteSpace(DepartmentFloorTxb.Text))
            {
                MessageBox.Show("Поля не могут быть пустыми");
            }
            else if (DepartmentGrid.SelectedItem != null)
            {
                object id = (DepartmentGrid.SelectedItem as DataRowView).Row[0];
                department.UpdateQuery(DepartmentTxb.Text, DepartmentFloorTxb.Text, Convert.ToInt32(id));
                DepartmentGrid.ItemsSource = department.GetData();
            }
            else
            {
                MessageBox.Show("Не было выбрано поле для изменения");
            }
        }

        private void DepartmentDeleteBt_Click(object sender, RoutedEventArgs e)
        {
            if (DepartmentGrid.SelectedItem == null)
            {
                MessageBox.Show("Не было выбрано поле для удаления");
            }
            else
            {
                object id = (DepartmentGrid.SelectedItem as DataRowView).Row[0];
                department.DeleteQuery(Convert.ToInt32(id));
                DepartmentGrid.ItemsSource = department.GetData();
            }
        }

        private void DepartmentBackBt_Click(object sender, RoutedEventArgs e)
        {
            new AdminWindow().Show();
            Close();
        }

        private void DepartmentGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DepartmentGrid.SelectedItem != null)
            {
                object cell = (DepartmentGrid.SelectedItem as DataRowView).Row[1];
                DepartmentTxb.Text = cell as string;
                object floor = (DepartmentGrid.SelectedItem as DataRowView).Row[2];
                DepartmentFloorTxb.Text = floor as string;
            }
        }

        private bool IsPositiveInteger(string input)
        {
            int result;
            return int.TryParse(input, out result) && result > 0;
        }

        private bool IsValidDepartmentName(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }
    }
}
