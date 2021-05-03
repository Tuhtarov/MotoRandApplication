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
using System.Windows.Shapes;

namespace MotoRandApplication.uix.frames.menu.operatorE
{
    /// <summary>
    /// Логика взаимодействия для OperatorMenu.xaml
    /// </summary>
    public partial class OperatorMenu : Window, IMainMenuFunction
    {
        private string employee;
        public OperatorMenu(string Employee)
        {
            InitializeComponent();
            employee = Employee;
            OperatorTextEmployee.Content = employee;
        }

        public void EmployeeClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ты кликнул на сотрудника");

        }

        public void MainMenuClick(object sender, MouseButtonEventArgs e)
        {

        }

        public void ToolbarClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ты кликнул на тул бар");
        }
    }
}
