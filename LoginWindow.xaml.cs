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
using MotoRandApplication.database;

namespace MotoRandApplication
{
    /// Логика взаимодействия для LoginWindow.xaml
    public partial class LoginWindow : Window
    {
        SqlConnection sqlConnection = null;
        MotoRandEntities context;
        const int six = 666666;
        public LoginWindow()
        {
            context = new MotoRandEntities();
            InitializeComponent();
        }

        private void test(int idpost)
        {
            var ct = context.City;
            var queryCityes = from City in ct
                              where City.IndexPost == idpost
                              select City.NameCity;
            MessageBox.Show(queryCityes.ToString());
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            test(six);

            /*if(CheckValidField.IsNotEmpty(fieldLogin.Text) && CheckValidField.IsNotEmpty(fieldPassword.Text))
            {
                MessageBox.Show("Поля не пустые", "Ввод");
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка ввода");
            }*/
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
