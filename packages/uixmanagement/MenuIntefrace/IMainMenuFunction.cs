using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MotoRandApplication.packages.uixmanagement.MenuIntefrace
{
    interface IMainMenuFunction
    {
        void MainMenuClick(object sender, MouseButtonEventArgs e);
        void ToolbarClick(object sender, MouseButtonEventArgs e);
        void EmployeeClick(object sender, MouseButtonEventArgs e);
    }
}
