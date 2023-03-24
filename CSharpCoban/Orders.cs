using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    public class Orders
    {
        public string OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double OrderTotal { get; set; }
    }
}
