using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MotoRandApplication
{
    public class CheckValidField
    {
        //проверка вводимых символов в поля авторизации (только латиница и цифры)
        public static bool IsNotEmpty(string str)
        {
            if(str != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //проверка Данных пользователя (логина или пароля) на отсутсвие спец.символов
        public static bool IsUserInputCorrect(string LoginOrPswd)
        {
            //char[] lp;
            //lp = LoginOrPswd.ToCharArray();
            if (Regex.IsMatch(LoginOrPswd, @"^[a-zA-Z0-9]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
