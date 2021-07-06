using AppRestaurant.Models;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurant.Mappings
{
    public class AccountMap : ClassMapping<AccountModel>
    {
        public AccountMap()
        {
            Schema("dbo");

            Table("Account");

            Id(x => x.IdAccount, map => map.Generator(Generators.Identity));

            Property(x => x.AccountLogin);

            Property(x => x.AccountPassword);

            Property(x => x.FirstName);

            Property(x => x.LastName);

            Property(x => x.IsAdmin);

            Property(x => x.DiscountCode);


            Set(x => x.OrderNumberList, m =>
            {
                m.Key(k => k.Column("IdAccount"));
                m.Inverse(true);
                m.Cascade(Cascade.All);

            }, r => r.OneToMany(x => x.Class(typeof(OrderNumberModel))));

        }
    }
}
