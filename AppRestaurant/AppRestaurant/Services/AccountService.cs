using AppRestaurant.Models;
using NHibernate;
using NHibernate.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace AppRestaurant.Services
{
    public class AccountService
    {
        public AccountModel GetLogin(string login, string pass)
        {
            AccountModel account;
            using (ISession session = NHService.OpenSession())
            {
                account = session.Query<AccountModel>()
                      .Where(x => x.AccountLogin == login && x.AccountPassword == pass)
                      .FirstOrDefault();
            }

            return account;
        }

        public List<AccountModel> GetAll()
        {

            using (ISession session = NHService.OpenSession())
            {
                var allAcc = session.Query<AccountModel>().ToList();
                return allAcc;
            }
        }

        public void Add(AccountModel entity)
        {

            using (ISession session = NHService.OpenSession())
            {
                using (ITransaction tran = session.BeginTransaction())
                {
                    session.SaveOrUpdate(entity);
                    tran.Commit();
                }
            }
        }

        public void Delete(AccountModel mod)
        {
            using (ISession session = NHService.OpenSession())
            {
                using (ITransaction tran = session.BeginTransaction())

                {
                    session.Delete(mod);
                    tran.Commit();
                }
            }
        }

    }
}
