using MotoRandApplication.packages.uixmanagement.MenuIntefrace;
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
    public partial class OperatorMenu : Window, IMainMenuFunction
    {
        private string employee;
        private OperatorMainMenu mainMenu;
        public OperatorMenu(string Employee)
        {
            InitializeComponent();
            employee = Employee;
            OperatorTextEmployee.Content = employee;
            mainMenu = new OperatorMainMenu();
            OperatorMenuFrame.Content = mainMenu;
        }

        public void EmployeeClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ты кликнул на сотрудника");

        }

        public void MainMenuClick(object sender, MouseButtonEventArgs e)
        {
            if(OperatorMenuFrame.Content != mainMenu)
            {
                OperatorMenuFrame.NavigationService.Navigate(mainMenu);
            }
        }

        public void ToolbarClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ты кликнул на тул бар");
        }
    }
}
