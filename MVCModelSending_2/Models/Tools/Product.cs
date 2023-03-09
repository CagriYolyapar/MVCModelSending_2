using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCModelSending_2.Models.Tools
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }

    }
}