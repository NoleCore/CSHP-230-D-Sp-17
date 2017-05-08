using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.WebSite.Models
{
    public class ClassModel
    {
        public ClassModel[] Class { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public decimal ClassPrice { get; set; }

        public ClassModel(int id, string name)
        {
            Name = name;
            Id = id;
            ClassId = id;
            ClassName = name;
            ClassDescription = ClassDescription;
            ClassPrice = ClassPrice;
        }
    }
}