using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Entities
{
    public class CommitedOrder
    {
        public virtual int Id { get; protected set; }
        public virtual required FoodType FoodType { get; set; }
        public virtual string Note { get; set; }
    }
}
