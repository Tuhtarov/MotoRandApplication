﻿using MotoRandApplication.packages.uixmanagement.MenuIntefrace;
using MotoRandApplication.uix.frames.capabilities.admin;
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

namespace MotoRandApplication.uix.frames.menu.admin
{
    /// <summary>
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window, IMainMenuFunction
    {
        private string employee;
        private AdminMainMenu mainMenu; 
        public AdminMenu(string Employee)
        {
            InitializeComponent();
            employee = Employee;
            AdminTextEmployee.Content = employee;
            mainMenu = new AdminMainMenu();
            AdminMenuFrame.Content = mainMenu;
        }

        public void EmployeeClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ты кликнул на сотрудника");

        }

        public void MainMenuClick(object sender, MouseButtonEventArgs e)
        {
            if(AdminMenuFrame.Content != mainMenu)
            {
                AdminMenuFrame.Content = mainMenu;
            }
        }

        public void ToolbarClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ты кликнул на тул бар");
        }
    }
}
