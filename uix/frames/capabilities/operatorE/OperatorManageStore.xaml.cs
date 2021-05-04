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

namespace MotoRandApplication.uix.frames.capabilities.operatorE
{
    /// <summary>
    /// Логика взаимодействия для OperatorManageStore.xaml
    /// </summary>
    public partial class OperatorManageStore : Page, IFrameFunction
    {
        Page context;

        public OperatorManageStore(Page cntxt)
        {
            InitializeComponent();
            context = cntxt;
        }

        public void OnClickExit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(context);
        }
    }
}
