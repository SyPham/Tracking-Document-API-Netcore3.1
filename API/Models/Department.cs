using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Department : EntityBase<int>
    {
        public Department()
        {
            this.CreateTime = DateTime.Now;
        }

        
        
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public virtual List<DepartmentLang> DepartmentLangs { get; set; }

    }
}