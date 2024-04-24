using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using Hospital.HospitalDataSetTableAdapters;

namespace Hospital
{
    public partial class DoctorAdminWindow : Window
    {
        CabinetTableAdapter cabinet = new CabinetTableAdapter();
        PostTableAdapter post = new PostTableAdapter();
        DoctorTableAdapter doctor = new DoctorTableAdapter();

        public DoctorAdminWindow()
        {
            InitializeComponent();

            DoctorGrid.ItemsSource = doctor.GetData();

            DoctorPostComboBox.ItemsSource = post.GetData();
            DoctorPostComboBox.DisplayMemberPath = "id_Post";
            DoctorPostComboBox.SelectedValuePath = "id_Post";

            DoctorCabinetComboBox.ItemsSource = cabinet.GetData();
            DoctorCabinetComboBox.DisplayMemberPath = "id_Cabinet";
            DoctorCabinetComboBox.SelectedValuePath = "id_Cabinet";
        }

        private void DoctorCreate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DoctorSurnameTxb.Text) ||
                string.IsNullOrWhiteSpace(DoctorNameTxb.Text) ||
                string.IsNullOrWhiteSpace(DoctorMidlleNameTxb.Text) ||
                string.IsNullOrWhiteSpace(DoctorPostComboBox.Text) ||
                string.IsNullOrWhiteSpace(DoctorCabinetComboBox.Text) ||
                !IsValidName(DoctorSurnameTxb.Text) ||
                !IsValidName(DoctorNameTxb.Text) ||
                !IsValidName(DoctorMidlleNameTxb.Text))
            {
                MessageBox.Show("Поле не может быть пустым или содержать цифры");
            }
            else
            {
                doctor.InsertQuery(DoctorSurnameTxb.Text, DoctorNameTxb.Text, DoctorMidlleNameTxb.Text,
                Convert.ToInt32(DoctorPostComboBox.Text), Convert.ToInt32(DoctorCabinetComboBox.Text));
                DoctorGrid.ItemsSource = doctor.GetData();
            }
        }

        private void DoctorUpdateBt_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DoctorSurnameTxb.Text) ||
                string.IsNullOrWhiteSpace(DoctorNameTxb.Text) ||
                string.IsNullOrWhiteSpace(DoctorMidlleNameTxb.Text) ||
                string.IsNullOrWhiteSpace(DoctorPostComboBox.Text) ||
                string.IsNullOrWhiteSpace(DoctorCabinetComboBox.Text))
            {
                MessageBox.Show("Поле не может быть пустым");
            }

            else if (DoctorGrid.SelectedItem != null)
            {
                object id = (DoctorGrid.SelectedItem as DataRowView).Row[0];
                doctor.UpdateQuery(DoctorSurnameTxb.Text, DoctorNameTxb.Text, DoctorMidlleNameTxb.Text, Convert.ToInt32(DoctorPostComboBox.Text), Convert.ToInt32(DoctorCabinetComboBox.Text), Convert.ToInt32(id));
                DoctorGrid.ItemsSource = doctor.GetData();
            }
            else
            {
                MessageBox.Show("Не было выбрано поле для изменения");
            }
        }

        private void DoctorDeleteBt_Click(object sender, RoutedEventArgs e)
        {
            if (DoctorGrid.SelectedItem == null)
            {
                MessageBox.Show("Не было выбрано поле для удаления");
            }
            else
            {
                object id = (DoctorGrid.SelectedItem as DataRowView).Row[0];
                doctor.DeleteQuery(Convert.ToInt32(id));
                DoctorGrid.ItemsSource = doctor.GetData();
            }
        }

        private void DoctorBackBt_Click(object sender, RoutedEventArgs e)
        {
            new AdminWindow().Show();
            Close();
        }

        private void DoctorGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DoctorGrid.SelectedItem != null)
            {
                object surname = (DoctorGrid.SelectedItem as DataRowView).Row[1];
                DoctorSurnameTxb.Text = surname as string;

                object name = (DoctorGrid.SelectedItem as DataRowView).Row[2];
                DoctorNameTxb.Text = name as string;

                object midlleName = (DoctorGrid.SelectedItem as DataRowView).Row[3];
                DoctorMidlleNameTxb.Text = midlleName as string;

                object id_Post = (DoctorGrid.SelectedItem as DataRowView).Row[4];
                DoctorPostComboBox.SelectedValue = id_Post;

                object id_Cabinet = (DoctorGrid.SelectedItem as DataRowView).Row[5];
                DoctorCabinetComboBox.SelectedValue = id_Cabinet;

            }
            if (DoctorGrid.SelectedItem == null)
            {
                DoctorGrid.ItemsSource = doctor.GetData();
            }
        }

        private bool IsValidName(string input)
        {
            return Regex.IsMatch(input, @"^[а-яА-Яa-zA-Z]+$");
        }
    }
}
