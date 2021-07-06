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
    public class OrderNumberService
    {
        public IList<OrderNumberModel> GetAll()
        {
            using (ISession session = NHService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var allOrders = session.Query<OrderNumberModel>().ToList();
                    return allOrders;
                }
            }
        }

        public List<OrderNumberModel> GetOrders(int id)
        {
            List<OrderNumberModel> getMyOrder = null;

            using (ISession session = NHService.OpenSession())
            {
                getMyOrder = session.Query<OrderNumberModel>()
                    .Where(x => x.AccountModel.IdAccount == id).ToList();

            }
            return getMyOrder;
        }


        public void SaveOrder(OrderNumberModel entity)
        {
            
         
            using (ISession session = NHService.OpenSession())
            {                
                using (ITransaction tran = session.BeginTransaction())
                {
                    //ITS UNUSED!!!!!!!!!!!!! U CAN USE IT TO GET DATA FROM DATABASE!!!!!!!!!!
                    //orderNumberModel = session.Query<OrderNumberModel>()
                    //.Where(x => x.AccountModel.IdAccount == id && x.TotalPrice == price).FirstOrDefault();

                    session.SaveOrUpdate(entity);
                    tran.Commit();
                }
            }
        }
    }
}
