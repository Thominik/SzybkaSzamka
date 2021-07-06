using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurant.Models
{
    public class OrderNumberModel
    {
        public virtual int IdOrder { get; set; }
        public virtual int TotalPrice { get; set; }
        public virtual AccountModel AccountModel { get; set; }
        public virtual ISet<OrderPositionModel> OrderPositionModelList1 { get; set; }
    }
}
