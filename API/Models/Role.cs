using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Role : EntityBase<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual List<Menu> Menus { get; set; }

    }
}