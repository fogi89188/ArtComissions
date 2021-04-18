using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class AccountProcessor
    {
        public static int CreateAccount(string firstName, string lastName, string email)
        {
            AccountModel data = new AccountModel
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            string sql = @"insert into dbo.AccountTable (FirstName, LastName, Email) values (@FirstName, @LastName, @Email)";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<AccountModel> LoadAccounts()
        {
            string sql = @"select Id, FirstName, LastName, Email from dbo.AccountTable";

            return SqlDataAccess.LoadData<AccountModel>(sql);
        }
    }
}
