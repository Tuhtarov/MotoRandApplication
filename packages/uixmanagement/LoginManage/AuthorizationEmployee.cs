using MotoRandApplication.database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoRandApplication.packages.uixmanagement.LoginManage
{
    public class AuthorizationEmployee : IAuthorizationEmployee
    {
        private string login;
        private string password;
        private string role;

        private MotoRandNewEntities context;
        private DbSet<Roles> roleDb;
        private DbSet<Accounts> accountsDb;
        private DbSet<Employees> employees;

        public AuthorizationEmployee(MotoRandNewEntities DbContext)
        {
            context = DbContext;
            roleDb = context.Roles;
            accountsDb = context.Accounts;
            employees = context.Employees;
        }


        public string CheckValidAuthorization(string Login, string Password, string Role)
        {
            login = Login;
            password = Password;
            role = Role;
            CheckInDataBase();
            return CheckInDataBase();
        }

        private string CheckInDataBase()
        {
             /*логика плохо отрабатывает
            var result = accountsDb.Where(acc => acc.Login == login && acc.Password == password);
            var roleValidation = result.Where(r => r.Roles.Role == role);

            var query = from Accounts in accountsDb where Accounts.Login == login && Accounts.Password == password select Accounts.IdAccount;
            var queryId = from Employees in employees where Employees.IdAccount == query.FirstOrDefault() select Employees.IdEmployee;
            var queryIdRole = from Roles in roleDb where */
            var idRole = (from Roles in roleDb where Roles.Role == role select Roles.IdRole).FirstOrDefault();

            if(idRole == 0)
            {
                return "неверно";
            }

            //тут достаётся ID аккаунта, если подтверждается - возращается его ID, если нет - возвращается 0
            var idAccount = (from Accounts in accountsDb where
                              Accounts.IdRole == idRole
                              && Accounts.Login == login 
                              && Accounts.Password == password
                              select Accounts.IdAccount).FirstOrDefault();

            //если ID аккаунта не равно нулю, взять Данные сотрудника, иначе отправить ошибку
            if(idAccount != 0)
            {
                var empId = (from Employees in (employees) where Employees.IdAccount == idAccount select Employees.IdEmployee).FirstOrDefault();
                return empId == 0 ? "неверно" : $"{employees.Find(empId).Name} {employees.Find(empId).Family} {employees.Find(empId).SecondName}";
            }
            else
            {
                return "неверно";
            }

            /*
            if (result.Select(r => r.Roles.Role == role).FirstOrDefault())
            {
                //var employeeData = roleValidation.Select(rV => rV.Employees.Where(emp => emp.IdAccount == rV.IdAccount));
                //return $"{employeeData.Select(e => e.Select(emp => emp.Family))} {employeeData.Select(e => e.Select(emp => emp.Name))} {employeeData.Select(e => e.Select(emp => emp.SecondName))}";
            } else
            {
                return "неверно";
            }
             */
        }
    }
}
