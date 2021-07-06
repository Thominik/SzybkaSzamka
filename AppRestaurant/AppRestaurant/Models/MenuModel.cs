using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurant.Models
{
    public class MenuModel
    {
        public virtual int IdMenu { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string Price { get; set; }
        public virtual ISet<OrderPositionModel> OrderPositionModelList { get; set; }

        public virtual int Quantity { get; set; }
        
    }
}
