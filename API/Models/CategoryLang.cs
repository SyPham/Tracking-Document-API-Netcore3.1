using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class CategoryLang : GeneralLang
    {
        public  int CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}