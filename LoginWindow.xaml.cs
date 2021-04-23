using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
//здесь подключения для работы с БД
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MotoRandApplication
{
    /// Логика взаимодействия для LoginWindow.xaml
    public partial class LoginWindow : Window
    {
        SqlConnection sqlConnection = null;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(CheckValidField.IsNotEmpty(fieldLogin.Text) && CheckValidField.IsNotEmpty(fieldPassword.Text))
            {
                MessageBox.Show("Поля не пустые", "Ввод");
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка ввода");
            }
        }

        private void loginField_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!CheckValidField.IsUserInputCorrect(e.Text))
            {
                e.Handled = true;
            }
        }

        private void LoadLoginWindow(object sender, RoutedEventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoRandConnect"].ConnectionString);
            sqlConnection.Open();
            if(sqlConnection.State == ConnectionState.Open)
            {
                textStateDB.Content = "Подключение к БД: установлено.";
            }
            else
            {
                textStateDB.Content = "Подключение к БД: не установлено.";
            }
        }
    }
}
