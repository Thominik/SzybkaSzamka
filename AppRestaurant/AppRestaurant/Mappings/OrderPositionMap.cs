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
    public class OrderPositionMap : ClassMapping<OrderPositionModel>
    {
        public OrderPositionMap()
        {
            Schema("dbo");

            Table("OrderPosition");

            Id(x => x.IdPosition, map => map.Generator(Generators.Identity));

            Property(x => x.Quantity);

            Property(x => x.Price);

            ManyToOne(x => x.MenuModel, m =>
            {
                m.Lazy(LazyRelation.NoLazy);
                m.Column("IdMenu");

            });

            ManyToOne(x => x.OrderNumberModel, m =>
            {
                m.Lazy(LazyRelation.NoLazy);
                m.Column("IdOrder");

            });
        }
    }
}
