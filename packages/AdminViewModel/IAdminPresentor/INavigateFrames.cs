using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MotoRandApplication.packages.AdminViewModel.IAdminPresentor
{
    interface INavigateFrames
    {
        // методы для перехода по пунктам оператора
        void GoOnDataProviders();
        void GoOnDataParts();
        void GoOnDataMotorcycles();
        void GoOnDataStore();

        // методы для перехода по пунктам "управления сотрудниками"
        void GoOnRegistrationUsers();
        void GoOnRegistrationEmployee();

        // методы для раздела "разное"
        void GoOnDataCustomers();


    }
}
