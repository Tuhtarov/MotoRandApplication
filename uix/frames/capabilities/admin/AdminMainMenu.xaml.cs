using MotoRandApplication.packages.AdminViewModel;
using MotoRandApplication.packages.uixmanagement.FrameInterface;
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

namespace MotoRandApplication.uix.frames.capabilities.admin
{
    /// <summary>
    /// Логика взаимодействия для AdminMainMenu.xaml
    /// </summary>
    public partial class AdminMainMenu : Page
    {
        AdminViewModel viewModel;
        public AdminMainMenu()
        {
            InitializeComponent();
            viewModel = new AdminViewModel(this);
        }

        private void ClickOnManageProviders(object sender, MouseButtonEventArgs e)
        {
            viewModel.GoOnDataProviders();
        }

        private void ClickOnManageParts(object sender, MouseButtonEventArgs e)
        {
            viewModel.GoOnDataParts();
        }

        private void ClickOnManageMotorcycles(object sender, MouseButtonEventArgs e)
        {
            viewModel.GoOnDataMotorcycles();
        }

        private void ClickOnManageProducts(object sender, MouseButtonEventArgs e)
        {
            viewModel.GoOnDataStore();
        }

        private void OnClickHelpInfo(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Справочная информация ещё не написана");
        }

        private void OnClickCustomersData(object sender, MouseButtonEventArgs e)
        {
            viewModel.GoOnDataCustomers();
        }

        private void ClickOnManageAccounts(object sender, MouseButtonEventArgs e)
        {
            viewModel.GoOnRegistrationUsers();
        }

        private void ClickOnManageEmployee(object sender, MouseButtonEventArgs e)
        {
            viewModel.GoOnRegistrationEmployee();
        }

        private void InDevelopment()
        {
            MessageBox.Show("В разработке");
        }

    }
}
