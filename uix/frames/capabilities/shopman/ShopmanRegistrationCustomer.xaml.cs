using MotoRandApplication.database;
using MotoRandApplication.packages.uixmanagement.FrameInterface;
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
    public partial class ShopmanRegistrationCustomer : Page, IFrameFunction
    {
        MotoRandNewEntities dbContext;
        private Page pageContext;


        public ShopmanRegistrationCustomer(Page pageContext)
        {
            dbContext = new MotoRandNewEntities();
            InitializeComponent();
            LoadDataInDataGrid();
            this.pageContext = pageContext;
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



        public void OnClickExit(object sender, RoutedEventArgs e) 
        { 
            NavigationService.Navigate(pageContext);
        }

        private void OnClickRegistration(object sender, RoutedEventArgs e)
        {
            if (FieldName.Text != "" && FieldFamily.Text != "" && FieldPatronymic.Text != "" && FieldPhone.Text != "")
            {
                var listData = dbContext.Customers.ToList();

                if (listData.Select(s => s.Name).Contains(FieldName.Text)
                    && listData.Select(s => s.Family).Contains(FieldFamily.Text)
                    && listData.Select(s => s.SecondName).Contains(FieldPatronymic.Text)
                    && listData.Select(s => s.Phone).Contains(FieldPhone.Text))
                {
                    MessageBox.Show("Такой пользователь уже существует.");
                    ClearUIFields();
                }
                else
                {
                    dbContext.Customers.Add(new Customers
                    {
                        Name = FieldName.Text,
                        Family = FieldFamily.Text,
                        SecondName = FieldPatronymic.Text,
                        Phone = FieldPhone.Text
                    });
                    dbContext.SaveChanges();
                    ClearUIFields();
                    CustomerDataGrid.ItemsSource = dbContext.Customers.ToList();
                }

            }
            else
            {
                MessageBox.Show("Что бы зарегистрировать клиента, необходимо заполнить все поля", "Ошибка записи");
            }
        }

        private void ClearUIFields()
        {
            FieldName.Text = "";
            FieldFamily.Text = "";
            FieldPatronymic.Text = "";
            FieldPhone.Text = "";
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            dbContext.SaveChanges();
        }

    }
}
