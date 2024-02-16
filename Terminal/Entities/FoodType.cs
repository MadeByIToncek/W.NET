using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Entities
{
    public class FoodType
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual int Price { get; set; }
    }
}
