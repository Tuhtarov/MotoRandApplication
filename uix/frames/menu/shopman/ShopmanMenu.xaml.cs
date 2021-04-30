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
        private ShopmanRegistrationCustomer registration;
        private ShopmanSell sell;


        public ShopmanMenu(String employee)
        {
            InitializeComponent();
            ShopManTextEmployee.Content = employee;
            frame = ShopmanMenuFrame;
            InitFrames();
            frame.Content = menu;
        }

        private void MainMenuClick(object sender, MouseButtonEventArgs e)
        {
            if (frame.Content != menu)
            {
                frame.NavigationService.Navigate(menu);
            }
        }

        private void ToolbarClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ты кликнул на тул бар");
        }

        private void EmployeeClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ты кликнул на сотрудника");
        }

        private void InitFrames()
        {
            menu = new ShopmanMainMenu();
            registration = new ShopmanRegistrationCustomer();
            sell = new ShopmanSell();
        }
    }
}
