using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurant.Models
{
    public class OrderPositionModel
    {
        public virtual int IdPosition { get; set; }
        public virtual MenuModel MenuModel { get; set; }
        public virtual OrderNumberModel OrderNumberModel { get; set; }
        public virtual int Quantity { get; set; }

        public virtual int Price { get; set; }
    }
}
