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

namespace MotoRandApplication
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

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
                MessageBox.Show("Заполните все поля!", "Ввод");
            }
        }

        private void loginField_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!CheckValidField.IsUserInputCorrect(e.Text))
            {
                e.Handled = true;
            }
        }
    }
}
