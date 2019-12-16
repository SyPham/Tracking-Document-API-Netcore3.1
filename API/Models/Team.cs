using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Team: EntityBase<int>
    {


        
        
        [Required]
        public string Name { get; set; }

        public int DepartmentID { get; set; }

        public virtual List<TeamLang> TeamLangs { get; set; }

    }
}