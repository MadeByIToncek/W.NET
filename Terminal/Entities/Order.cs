namespace Terminal.Entities
{
    public class Order
    {
        public virtual int Id { get; protected set; }
        public virtual int CisloListecku { get; set; }
        public virtual List<CommitedOrder> Stuff { get; set; }

        public Order()
        {
            Stuff = [];
        }
    }
}
