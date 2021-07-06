using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurant.Models
{
    public class AccountModel
    {
        public virtual int IdAccount { get; set; }
        public virtual string AccountLogin { get; set; }
        public virtual string AccountPassword { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual ISet<OrderNumberModel> OrderNumberList { get; set; }
        public virtual bool IsAdmin { get; set; }

        public virtual string DiscountCode { get; set; }


        //public virtual string KodPromocyjny
        //{
        //    get
        //    {
        //        string code = "";
        //        if (DiscountCodeModel != null)
        //            code = DiscountCodeModel.Code;

        //        return code;
        //    }
        //    set { }
        //}

    }
}
