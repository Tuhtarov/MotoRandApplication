﻿using System;
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
using MotoRandApplication.packages.uimanagement;
//здесь подключения для работы с БД

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MotoRandApplication.database;
using MotoRandApplication.uix.frames.menu.shopman;
using MotoRandApplication.packages.uixmanagement.LoginManage;
using MotoRandApplication.uix.frames.menu.operatorE;
using MotoRandApplication.uix.frames.menu.admin;

namespace MotoRandApplication
{
    /// Логика взаимодействия для LoginWindow.xaml
    public partial class LoginWindow : Window
    {
        SqlConnection motoRandConnection = null;
        MotoRandNewEntities contextDB;
        Window mainMenu;
        AuthorizationEmployee authorization;

        Watermarks loginPlaceholder;
        Watermarks passwordPlaceholder;

        public LoginWindow()
        {
            InitializeComponent();
            InitUtils();
        }

        private void LoadLoginWindow(object sender, RoutedEventArgs e)
        {
            motoRandConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoRandNewConnect"].ConnectionString);
            motoRandConnection.Open();
            contextDB = new MotoRandNewEntities();
            authorization = new AuthorizationEmployee(contextDB);
        }

        private void clickSignIn(object sender, RoutedEventArgs e)
        {
          
            if(loginField.Text != "" && passwordField.Text != "")
            {
                var resultValid = authorization.CheckValidAuthorization(loginField.Text, passwordField.Text, CBchooseRole.Text);
                if (authorization.CheckValidAuthorization(loginField.Text, passwordField.Text, CBchooseRole.Text) != "неверно")
                {
                    switch (CBchooseRole.Text)
                    {
                        case "Продавец":
                            mainMenu = new ShopmanMenu(resultValid);
                            break;
                        case "Оператор":
                            mainMenu = new OperatorMenu(resultValid);
                            break;
                        case "Администратор":
                            mainMenu = new AdminMenu(resultValid);
                            break;
                    }
                    this.Close();
                    mainMenu.Show();
                } else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }

            } else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButton.OK);
            }

        }

        private void OnTextChangedSignIn(object sender, TextChangedEventArgs e)
        {
            loginField.Background = loginField.Text == "" ? loginPlaceholder.GetPlaceholder() : null;
            passwordField.Background = passwordField.Text == "" ? passwordPlaceholder.GetPlaceholder() : null;
        }

        private void InitUtils()
        {
            loginPlaceholder = new Watermarks(@"C:\Users\tuhtarov\Desktop\projectsVS\MotoRandApplication\res\images\watermarks\loginholder.png");
            passwordPlaceholder = new Watermarks(@"C:\Users\tuhtarov\Desktop\projectsVS\MotoRandApplication\res\images\watermarks\passwordholder.png");
        }
    }


}
