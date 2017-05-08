using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ziggle.WebSite.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}