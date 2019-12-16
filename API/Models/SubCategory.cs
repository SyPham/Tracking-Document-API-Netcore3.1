using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class SubCategory: EntityBase<int>
    {
        public SubCategory()
        {
            this.CreateTime = DateTime.Today;
        }
        
        public string Name { get; set; }

        public DateTime CreateTime { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<SubCategoryLang> SubCategoryLangs { get; set; }

    }
}