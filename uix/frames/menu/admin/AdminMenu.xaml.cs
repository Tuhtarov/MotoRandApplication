using MotoRandApplication.packages.AdminViewModel;
using MotoRandApplication.packages.uimanagement;
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
    public partial class AdminMenu : Window
    {
        private SideBarAnimation sideBarAnimation;
        private AdminMainMenu mainMenu;
        private AdminViewModel viewModel;
        public AdminMenu(string Employee)
        {
            InitializeComponent();
            mainMenu = new AdminMainMenu();
            viewModel = new AdminViewModel(mainMenu);
            AdminTextEmployee.Content = Employee;
            AdminMenuFrame.Content = mainMenu;


            sideBarAnimation = new SideBarAnimation(sideMenu, textMenu);
        }

        private void ClickOnSideBar(object sender, RoutedEventArgs e)
        {
            sideBarAnimation.SideStart();
        }

        private void ClickDesktop(object sender, MouseButtonEventArgs e)
        {
            AdminMenuFrame.Content = viewModel.pageContext;
        }

        private void ClickAccounts(object sender, MouseButtonEventArgs e)
        {
            AdminMenuFrame.Content = viewModel.manageAccount;
        }

        private void ClickEmployees(object sender, MouseButtonEventArgs e)
        {
            AdminMenuFrame.Content = viewModel.manageEmployee;
        }

        private void ClickCustomer(object sender, MouseButtonEventArgs e)
        {
            AdminMenuFrame.Content = viewModel.manageRegistration;
        }

        private void BtnLeaveSystem_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
