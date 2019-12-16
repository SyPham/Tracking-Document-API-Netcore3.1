using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Category: EntityBase<int>
    {
        public Category()
        {
            this.CreateTime = DateTime.Now;
        }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public virtual List<CategoryLang> CategoryLangs { get; set; }
        public virtual List<SubCategory> SubCategories { get; set; }

    }
}