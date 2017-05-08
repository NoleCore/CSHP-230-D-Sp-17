using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ziggle.WebSite.Models
{
    public class CategoryViewModel
    {
        public CategoryModel Category { get; set; }
        public ProductModel[] Products { get; set; }
    }
}