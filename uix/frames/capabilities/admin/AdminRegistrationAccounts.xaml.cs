﻿using MotoRandApplication.packages.uixmanagement.FrameInterface;
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
    /// Логика взаимодействия для AdminRegistrationAccounts.xaml
    /// </summary>
    public partial class AdminRegistrationAccounts : Page, IFrameFunction
    {
        Page context;
        public AdminRegistrationAccounts(Page context)
        {
            InitializeComponent();
            this.context = context;
        }

        public void OnClickExit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(context);
        }
    }
}