using MotoRandApplication.packages.AdminViewModel;
using MotoRandApplication.packages.uimanagement;
using MotoRandApplication.uix.frames.capabilities.shopman;
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

namespace MotoRandApplication.uix.frames.menu.shopman
{

    public partial class ShopmanMenu : Window
    {
        private Frame frame;
        private ShopmanMainMenu menu;
        private AdminViewModel navigationModel;
        private SideBarAnimation sideBarAnimation;


        public ShopmanMenu(String employee)
        {
            InitializeComponent();
            ShopmanTextEmployee.Content = employee;
            frame = ShopmanMenuFrame;
            sideBarAnimation = new SideBarAnimation(sideMenu, textMenu);
            InitFrames();
            frame.Content = menu;
            navigationModel = new AdminViewModel(menu);
        }

        public void MainMenuClick(object sender, MouseButtonEventArgs e)
        {
            if (frame.Content != menu)
            {
                frame.NavigationService.Navigate(menu);
            }
        }

        public void ClickStore(object sender, MouseButtonEventArgs e)
        {
            ShopmanMenuFrame.Content = navigationModel.manageSell;
        }
        public void ClickCustomerRegistration(object sender, MouseButtonEventArgs e)
        {
            ShopmanMenuFrame.Content = navigationModel.manageRegistration;
        }

        private void InitFrames()
        {
            menu = new ShopmanMainMenu();
        }

        private void ClickOnSideBar(object sender, RoutedEventArgs e)
        {
            sideBarAnimation.SideStart();
        }

        private void BtnLeaveSystem_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
