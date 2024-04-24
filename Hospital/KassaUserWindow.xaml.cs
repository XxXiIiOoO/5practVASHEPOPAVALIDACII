using Hospital.HospitalDataSetTableAdapters;
using System;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Hospital
{
    public partial class KassaUserWindow : Window
    {
        Cheque_serviceTableAdapter CS = new Cheque_serviceTableAdapter();
        ChequeTableAdapter cheque = new ChequeTableAdapter();
        ServiceeTableAdapter service = new ServiceeTableAdapter();

        int Summa = 0;

        public KassaUserWindow()
        {
            InitializeComponent();

            ChequeServiceGrid.ItemsSource = CS.GetData();
            TalonGrid.ItemsSource = cheque.GetData();
            ServiceGrid.ItemsSource = service.GetData();

            TalonComboBox.ItemsSource = cheque.GetData();
            TalonComboBox.DisplayMemberPath = "id_Cheque";
            TalonComboBox.SelectedValuePath = "id_Cheque";
        }

        private void BackBt_Click(object sender, RoutedEventArgs e)
        {
            new UserWindow().Show();
            Close();
        }

        private void UpdateChequeBt_Click(object sender, RoutedEventArgs e)
        {
            if (TalonComboBox.SelectedItem == null)
            {
                MessageBox.Show("Не был выбран талон");
            }
            else if (ServiceGrid.SelectedItem == null)
            {
                MessageBox.Show("Не была выбрана услуга");
            }
            else
            {
                int idT = Convert.ToInt32(TalonComboBox.SelectedValue);
                int idS = Convert.ToInt32((ServiceGrid.SelectedItem as DataRowView)[0]);
                var name = (ServiceGrid.SelectedItem as DataRowView).Row[1];
                var cost = (ServiceGrid.SelectedItem as DataRowView).Row[2];
                int cost2 = Convert.ToInt32(cost);

                CS.InsertQuery(idT, idS);
                ChequeServiceGrid.ItemsSource = CS.GetData();

                var idCheka = Convert.ToInt32(idT);
                string txt = "Hospital\nКассовый чек #" + idCheka + "\n";
                File.WriteAllText("C:\\Users\\xacha\\OneDrive\\Рабочий стол\\я устал #" + idCheka + ".txt", txt);
                File.AppendAllText("C:\\Users\\xacha\\OneDrive\\Рабочий стол\\я устал #" + idCheka + ".txt", "\n" + name + "-" + cost2 + "\n");
                Summa += cost2;
            }
        }

        private void CloseChequeBt_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Polucheno.Text))
            {
                MessageBox.Show("Поле не может быть пустым");
            }
            else if (!IsPositiveInteger(Polucheno.Text))
            {
                MessageBox.Show("Сумма должна быть положительным числом");
            }
            else if (TalonComboBox.SelectedItem == null)
            {
                MessageBox.Show("Не был выбран талон");
            }
            else if (ServiceGrid.SelectedItem == null)
            {
                MessageBox.Show("Не была выбрана услуга");
            }
            else
            {
                object id = TalonComboBox.Text;
                var idCheka = Convert.ToInt32(id);
                var poluch = Convert.ToInt32(Polucheno.Text);
                var cdacha = poluch - Summa;
                string txt = "\nИтого к оплате: " + Summa + "\nВнесено: " + Polucheno.Text + "\nСдача: " + cdacha;
                File.AppendAllText("C:\\Users\\xacha\\OneDrive\\Рабочий стол\\я устал #" + idCheka + ".txt", txt);
                Close();
            }
        }

        private bool IsPositiveInteger(string input)
        {
            int result;
            return int.TryParse(input, out result) && result > 0;
        }
    }
}
