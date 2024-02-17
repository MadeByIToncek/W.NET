using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Entities;

namespace Terminal.Mapping
{
    public class OrderManifest : ClassMap<Order>
    {
        public OrderManifest()
        {
            Id(x => x.Id);
            Map(x => x.CisloListecku);
            HasManyToMany(x => x.Stuff)
                .Cascade.All()
                .Inverse();
        }
    }
}
