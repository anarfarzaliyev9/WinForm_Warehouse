using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
   public class Order
    {
        public Customer Client = null;

        public Product Product = null;
        public int Quantity { get; set; }

        public DateTime ArriveTime ;
        public DateTime OrderTime;
    }
}
