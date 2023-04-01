using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        private static readonly object instanceLock = new object();
        public AccountDAO() { }
        public static AccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();

                    }
                    return instance;
                }
            }
        }

        public Account GetAccByEmailPassword(string email, string password)
        {
            var acc = new Account();

            BookLibrariContext context = new BookLibrariContext();
            acc = context.Accounts.FirstOrDefault(a => a.Email == email && a.Password == password);


            return acc;

        }

        public List<Account> GetAccountList()
        {
            List<Account> per = null;
            try
            {
                using BookLibrariContext context = new BookLibrariContext();
                per = context.Accounts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return per;

        }
    }
}
