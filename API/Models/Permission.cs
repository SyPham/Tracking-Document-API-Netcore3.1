using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Permission : EntityBase<int>
    {
     
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<PermissionDetail> PermissionDetails { get; set; }

    }
}