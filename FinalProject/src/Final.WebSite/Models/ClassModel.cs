using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.WebSite.Models
{
    public class ClassModel
    {
        
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public decimal ClassPrice { get; set; }

        public ClassModel(int id, string name, string Description, decimal Price)
        {
            
            ClassId = id;
            ClassName = name;
            ClassDescription = Description;
            ClassPrice = Price;
        }
    }
}