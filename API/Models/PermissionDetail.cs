using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class PermissionDetail : EntityBase<int>
    {
     
        public string NameAction { get; set; }
        public string CodeAction { get; set; }
        public int PermisionID { get; set; }
        [ForeignKey("PermisionID")]
        public virtual Permission Permission { get; set; }
    }
}