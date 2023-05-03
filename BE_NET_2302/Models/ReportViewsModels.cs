using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BE_NET_2302.Models
{
    public class ReportViewsModels
    {
       public DateTime ReportDate { get; set; }
        public string CustomerName { get; set; }
        public string Casher { get; set; }
        public string ProductName { get; set; }
    }
}