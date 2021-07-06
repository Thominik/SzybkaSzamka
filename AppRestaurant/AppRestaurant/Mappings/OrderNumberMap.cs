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
    public class OrderNumberMap : ClassMapping<OrderNumberModel>
    {
        public OrderNumberMap()
        {
            Schema("dbo");

            Table("OrderNumber");

            Id(x => x.IdOrder, map => map.Generator(Generators.Identity));

            Property(x => x.TotalPrice);

            ManyToOne(x => x.AccountModel, m =>
            {
                m.Lazy(LazyRelation.NoLazy);
                m.Column("IdAccount");

            });

            Set(x => x.OrderPositionModelList1, m =>
            {
                m.Key(k => k.Column("IdOrder"));
                m.Inverse(true);
                m.Cascade(Cascade.All);

            }, r => r.OneToMany(x => x.Class(typeof(OrderPositionModel))));

        }
    }
}
