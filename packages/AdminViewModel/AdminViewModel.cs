using GalaSoft.MvvmLight.Command;
using MotoRandApplication.packages.AdminViewModel.IAdminPresentor;
using MotoRandApplication.uix.frames.capabilities.admin;
using MotoRandApplication.uix.frames.capabilities.operatorE;
using MotoRandApplication.uix.frames.capabilities.shopman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace MotoRandApplication.packages.AdminViewModel
{
    class AdminViewModel : INavigateFrames
    {
        public Page pageContext { get; }
        // operator capabilities
        private OperatorManageMotorcycles manageMoto;
        private OperatorManageProviders manageProviders;
        private OperatorManageStore manageStore;
        private OperatorManageParts manageParts;
        // shopman capabilities
        private ShopmanRegistrationCustomer manageRegistration;
        // admin capabilities
        private AdminRegistrationAccounts manageAccount;
        private AdminRegistrationEmployee manageEmployee;


        public AdminViewModel(Page page)
        {
            pageContext = page;
            manageEmployee = new AdminRegistrationEmployee(pageContext);
            manageAccount = new AdminRegistrationAccounts(pageContext);
            manageMoto = new OperatorManageMotorcycles(pageContext);
            manageParts = new OperatorManageParts(pageContext);
            manageStore = new OperatorManageStore(pageContext);
            manageProviders = new OperatorManageProviders(pageContext);
            manageRegistration = new ShopmanRegistrationCustomer(pageContext); 
        }

        public void GoOnDataProviders()
        {
            GoOn(manageProviders);
        }

        public void GoOnDataParts()
        {
            GoOn(manageParts);
        }

        public void GoOnDataMotorcycles()
        {
            GoOn(manageMoto);
        }

        public void GoOnDataStore()
        {
            GoOn(manageStore);
        }



        public void GoOnRegistrationUsers()
        {
            GoOn(manageAccount);
        }

        public void GoOnRegistrationEmployee()
        {
            GoOn(manageEmployee);
        }


        public void GoOnDataCustomers()
        {
            GoOn(manageRegistration);
        }

        private void GoOn(Page navigateOnPage)
        {
            pageContext.NavigationService.Navigate(navigateOnPage);
        }

    }
}
