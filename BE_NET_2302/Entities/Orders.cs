using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BE_NET_2302.Entities
{
    public class Orders
    {
        [Key]
        public string OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double OrderTotal { get; set; }

        public DateTime OrderDate { get; set; }
    }
}