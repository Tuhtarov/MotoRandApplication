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

namespace MotoRandApplication.uix.frames.capabilities.shopman
{
    public partial class ShopmanRegistrationCustomer : Page
    {
        public ShopmanRegistrationCustomer()
        {
            InitializeComponent();
        }

        private void OnClickExit(object sender, RoutedEventArgs e) 
        { 
            NavigationService.Navigate(new ShopmanMainMenu());
        }

    }
}
