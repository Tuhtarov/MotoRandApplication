using MotoRandApplication.packages.uixmanagement.MenuIntefrace;
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

namespace MotoRandApplication.uix.frames.capabilities.operatorE
{
    /// <summary>
    /// Логика взаимодействия для OperatorMainMenu.xaml
    /// </summary>
    public partial class OperatorMainMenu : Page
    {
        public OperatorManageMotorcycles manageMotorcycles;
        public OperatorManageParts manageParts;
        public OperatorManageStore manageStore;
        public OperatorManageProviders manageProviders;

        public OperatorMainMenu()
        {
            InitializeComponent();
            manageMotorcycles = new OperatorManageMotorcycles(this);
            manageParts =  new OperatorManageParts(this);
            manageStore = new OperatorManageStore(this);
            manageProviders = new OperatorManageProviders(this);
        }

        private void ClickOnManageProviders(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(manageProviders);
            InDevelopment();
        }

        private void ClickOnManageParts(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(manageParts);
            InDevelopment();
        }

        private void ClickOnManageMotorcycles(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(manageMotorcycles);
            InDevelopment();
        }

        private void ClickOnManageProducts(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(manageStore);
            InDevelopment();
        }

        private void OnClickHelpInfo(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Справочная информация ещё не написана");
        }

        private void InDevelopment()
        {
            MessageBox.Show("В разработке");
        }
    }
}
