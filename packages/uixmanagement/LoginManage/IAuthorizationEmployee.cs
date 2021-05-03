using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoRandApplication.packages.uixmanagement.LoginManage
{
    interface IAuthorizationEmployee
    {
        string CheckValidAuthorization(string Login, string Password, string Role);

    }
}
