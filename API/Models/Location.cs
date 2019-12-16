using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Location: EntityBase<int>
    {
        [Column("Name")]
        public string Name { get; set; }

        public string Remark { get; set; }

        public int DepartmentID { get; set; }

        public int TeamID { get; set; }

        public string LanguageID { get; set; }
        public virtual List<LocationLang> LocationLangs { get; set; }

    }
}