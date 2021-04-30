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

        MotoRandNewEntities contextDB;
        SqlConnection motoRandConnection = null;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoadLoginWindow(object sender, RoutedEventArgs e)
        {
            motoRandConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoRandNewConnect"].ConnectionString);
            motoRandConnection.Open();
            contextDB = new MotoRandNewEntities();
        }

        private void clickSignIn(object sender, RoutedEventArgs e)
        {

            var acc = contextDB.Accounts;
            var emp = contextDB.Employees;

            var query = from Accounts in acc where Accounts.Login == loginField.Text select Accounts.IdAccount;
            var queryTwo = from Employees in emp where Employees.IdAccount == query.FirstOrDefault() select Employees.IdEmployee;

            if(loginField.Text != "" && passwordField.Text != "")
            {
                if(query.FirstOrDefault() != 0){
                    var value = $"{contextDB.Employees.Find(queryTwo.FirstOrDefault()).Name}" +
                        $" {contextDB.Employees.Find(queryTwo.FirstOrDefault()).Family}" +
                        $" {contextDB.Employees.Find(queryTwo.FirstOrDefault()).SecondName}";

                    MessageBox.Show($"Здарова {value}");

                    /* var accaunt = contextDB.Accounts.Where(a => a.Login == loginField.Text && a.Password == passwordField.Text);
                    var ack = accaunt as Employees;
                    

                    Employees employee = (Employees)contextDB.Employees.Where(em => em.IdAccount == accaunt.IdAccount);
                    MessageBox.Show(employee.Name + " " + employee.Family); */
                }
                else
                {
                    MessageBox.Show("Не вход");
                }

            /* switch (CBchooseRole.Text)
            {
                case "Продавец":
                    MessageBox.Show($"Продавец {contextDB.Employees.Find(2).Name + " а его фама))) " + contextDB.Employees.Find(2).Family}");
                    break;
                case "Администратор":
                    MessageBox.Show("Администратор");
                    break;
                case "Оператор":
                    MessageBox.Show("Оператор");
                    break;
                default:
                    MessageBox.Show("Выберите роль");
                    break;
            } */

            } else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButton.OK);
            }

        }


        //вот здесь остановился
        private void loginFieldChanged(object sender, TextChangedEventArgs e)
        {
            if(loginField.Text == "")
            {
                loginField.Text = "Логин";
                loginField.Foreground = Brushes.Gray;
            }
            else
            {
                loginField.Foreground = Brushes.Black;
            }
        }
    }
}
