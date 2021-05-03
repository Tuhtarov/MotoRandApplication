using MotoRandApplication.database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        MotoRandNewEntities dbContext;


        public ShopmanRegistrationCustomer()
        {
            dbContext = new MotoRandNewEntities();
            InitializeComponent();
            LoadDataInDataGrid();
        }


        private void LoadDataInDataGrid()
        {
            try
            {
                CustomerDataGrid.ItemsSource = dbContext.Customers.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show($"ошибка {e.Message}");
                throw;
            }
        }



        private void OnClickExit(object sender, RoutedEventArgs e) 
        { 
            NavigationService.Navigate(new ShopmanMainMenu());
        }

        private void OnClickRegistration(object sender, RoutedEventArgs e)
        {
            if (FieldName.Text != "" && FieldFamily.Text != "" && FieldPatronymic.Text != "" && FieldPhone.Text != "")
            {

                dbContext.Customers.Add(new Customers
                {
                    Name = FieldName.Text,
                    Family = FieldFamily.Text,
                    SecondName = FieldPatronymic.Text,
                    Phone = FieldPhone.Text
                });
                dbContext.SaveChanges();
                CustomerDataGrid.ItemsSource = dbContext.Customers.ToList();


            }
            else
            {
                MessageBox.Show("Что бы зарегистрировать клиента, необходимо заполнить все поля", "Ошибка записи");
            }
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            dbContext.SaveChanges();
        }

    }
}
