using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using Hospital.HospitalDataSetTableAdapters;

namespace Hospital
{
    public partial class Payment_methodAdminWindow : Window
    {
        Payment_methodTableAdapter payment = new Payment_methodTableAdapter();

        public Payment_methodAdminWindow()
        {
            InitializeComponent();
            PaymentGrid.ItemsSource = payment.GetData();
        }

        private void PaymentCreate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PaymentTxb.Text) || !IsValidPaymentMethod(PaymentTxb.Text))
            {
                MessageBox.Show("Поле не может быть пустым или содержать цифры");
            }
            else
            {
                payment.InsertQuery(PaymentTxb.Text);
                PaymentGrid.ItemsSource = payment.GetData();
            }
        }

        private void PaymentUpdateBt_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PaymentTxb.Text) || !IsValidPaymentMethod(PaymentTxb.Text))
            {
                MessageBox.Show("Поле не может быть пустым или содержать цифры");
            }
            else if (PaymentGrid.SelectedItem != null)
            {
                object id = (PaymentGrid.SelectedItem as DataRowView).Row[0];
                payment.UpdateQuery(PaymentTxb.Text, Convert.ToInt32(id));
                PaymentGrid.ItemsSource = payment.GetData();
            }
            else
            {
                MessageBox.Show("Не было выбрано поле для изменения");
            }
        }

        private void PaymentDeleteBt_Click(object sender, RoutedEventArgs e)
        {
            if (PaymentGrid.SelectedItem == null)
            {
                MessageBox.Show("Не было выбрано поле для удаления");
            }
            else
            {
                object id = (PaymentGrid.SelectedItem as DataRowView).Row[0];
                payment.DeleteQuery(Convert.ToInt32(id));
                PaymentGrid.ItemsSource = payment.GetData();
            }
        }

        private void PaymentBackBt_Click(object sender, RoutedEventArgs e)
        {
            new AdminWindow().Show();
            Close();
        }

        private void PaymentGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PaymentGrid.SelectedItem != null)
            {
                object cell = (PaymentGrid.SelectedItem as DataRowView).Row[1];
                PaymentTxb.Text = cell as string;
            }
            else if (PaymentGrid.SelectedItem != null)
            {
                PaymentGrid.ItemsSource = payment.GetData();
            }
        }

        private bool IsValidPaymentMethod(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }
    }
}
