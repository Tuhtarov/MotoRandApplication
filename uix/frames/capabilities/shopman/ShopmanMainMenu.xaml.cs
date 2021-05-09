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
using MotoRandApplication.packages.AdminViewModel;
using MotoRandApplication.uix.frames.menu.shopman;

namespace MotoRandApplication.uix.frames.capabilities.shopman
{

    public partial class ShopmanMainMenu : Page
    {
        private AdminViewModel navigationModel;
        public ShopmanMainMenu()
        {
            InitializeComponent();
            navigationModel = new AdminViewModel(this);
        }

        private void OnClickSell(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(navigationModel.manageSell);
        }

        private void OnClickRegistration(object sender, MouseButtonEventArgs e)
        {
            navigationModel.GoOnDataCustomers();
        }

        private void OnClickHelpInfo(object sender, MouseButtonEventArgs e)
        {
            //NavigationService.Navigate();
            MessageBox.Show("В разработке, строка кода 44, класс MainMenu");
        }

    }
}
