using AppRestaurant.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace AppRestaurant.Services
{
    public class MenuService
    {
        public List<MenuModel> GetAll()
        {
            using (ISession session = NHService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var menuProd = session.Query<MenuModel>().ToList();
                    return menuProd;
                }
            }
        }

        public void Add(MenuModel entity)
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

        public void Delete(MenuModel mods)
        {
            using (ISession session = NHService.OpenSession())
            {
                using (ITransaction tran = session.BeginTransaction())

                {
                    session.Delete(mods);
                    tran.Commit();
                }
            }
        }
    }
}
