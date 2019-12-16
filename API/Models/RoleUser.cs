using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class RoleUser : EntityBase<int>
    {
        public RoleUser()
        {
            UpdateTime = DateTime.Today;
        }

      
        [ForeignKey("RoleID")]
        public int RoleID { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public virtual List<UserAccount> UserAccounts { get; set; }
        public virtual List<Role> Roles { get; set; }
        public DateTime UpdateTime { get; set; }
    }
    
}