using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Entities;

namespace Terminal.Mapping
{
    public class FoodTypeManifest : ClassMap<FoodType>
    {
        public FoodTypeManifest()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Price);
        }
    }
}
