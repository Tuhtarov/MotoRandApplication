using MotoRandApplication.packages.AdminViewModel;
using MotoRandApplication.packages.uimanagement;
using MotoRandApplication.uix.frames.capabilities.operatorE;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MotoRandApplication.uix.frames.menu.operatorE
{
    /// <summary>
    /// Логика взаимодействия для OperatorMenu.xaml
    /// </summary>
    public partial class OperatorMenu : Window
    {
        private OperatorMainMenu mainMenu;
        private SideBarAnimation sideBarAnimation;
        private AdminViewModel navigationModel;
        public OperatorMenu(string Employee)
        {
            InitializeComponent();
            OperatorTextEmployee.Content = Employee;
            mainMenu = new OperatorMainMenu();
            navigationModel = new AdminViewModel(mainMenu);
            sideBarAnimation = new SideBarAnimation(sideMenu, textMenu);


            OperatorMenuFrame.Content = mainMenu;
        }

        public void MainMenuClick(object sender, MouseButtonEventArgs e)
        {
            if(OperatorMenuFrame.Content != mainMenu)
            {
                OperatorMenuFrame.NavigationService.Navigate(mainMenu);
            }
        }

        private void ClickOnSideBar(object sender, RoutedEventArgs e)
        {
            sideBarAnimation.SideStart();
        }

        private void ClickStore(object sender, MouseButtonEventArgs e)
        {
            OperatorMenuFrame.Content = navigationModel.manageStore;
        }

        private void ClickProviders(object sender, MouseButtonEventArgs e)
        {
            OperatorMenuFrame.Content = navigationModel.manageProviders;
        }

        private void ClickMotorcycle(object sender, MouseButtonEventArgs e)
        {
            OperatorMenuFrame.Content = navigationModel.manageMoto;
        }

        private void ClickWarehouse(object sender, MouseButtonEventArgs e)
        {
            OperatorMenuFrame.Content = navigationModel.manageParts;
        }

        private void BtnLeaveSystem_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
