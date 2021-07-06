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
    public class MenuMap : ClassMapping<MenuModel>
    {
        public MenuMap()
        {
            Schema("dbo");

            Table("Menu");

            Id(x => x.IdMenu, map => map.Generator(Generators.Identity));

            Property(x => x.ProductName);

            Property(x => x.Price);

            Set(x => x.OrderPositionModelList, m =>
            {
                m.Key(k => k.Column("IdMenu"));
                m.Inverse(true);
                m.Cascade(Cascade.All);

            }, r => r.OneToMany(x => x.Class(typeof(OrderPositionModel))));

            
        }
    }
}
