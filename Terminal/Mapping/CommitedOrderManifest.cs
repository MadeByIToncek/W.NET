using FluentNHibernate.Mapping;
using Terminal.Entities;

namespace Terminal.Mapping
{
    public class CommitedOrderManifest : ClassMap<CommitedOrder>
    {
        public CommitedOrderManifest()
        {
            Id(x => x.Id);
            HasOne(x => x.FoodType)
                .Cascade.All();
            Map(x => x.Note);
        }
    }
}
