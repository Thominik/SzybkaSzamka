using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurant.Models.DataSourceDTOs
{
    public class AccountModelDataSourceDTO
    {
        public AccountModelDataSourceDTO(AccountModel model)
        {       
            IdAccount = model.IdAccount;
            AccountLogin = model.AccountLogin;
            AccountPassword = model.AccountPassword;
            FirstName = model.FirstName;
            LastName = model.LastName;
           // KodPromocyjny = model.DiscountCodeModel.Code;
        }
            
        public int IdAccount { get; set; }
        public string AccountLogin { get; set; }
        public string AccountPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string KodPromocyjny{ get; set; }
    }
}
