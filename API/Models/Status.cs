using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Status : EntityBase<int>
    {
   
     
        public string Name { get; set; }
        [Column("Code")]
        public string Code { get; set; }
        public virtual List<StatusLang> StatusLangs { get; set; }

    }
}