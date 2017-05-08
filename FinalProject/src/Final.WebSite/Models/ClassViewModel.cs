using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.WebSite.Models
{
    public class ClassViewModel
    {
        public ClassModel Class { get; set; }
        public SchoolModel[] Users { get; set; }
        public ClassModel[] Classes { get; set; }
    }
}