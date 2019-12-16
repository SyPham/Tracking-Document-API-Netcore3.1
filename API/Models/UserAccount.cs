using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class UserAccount : EntityBase<int>
    {
        public UserAccount()
        {
            this.CreateTime = DateTime.Now;
        }

        [Required]
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }
        
        public string Avatar { get; set; }

        public DateTime CreateTime { get; set; }

        public int Index { get; set; }

        public bool Status { get; set; }

        public string IDcardNumber { get; set; }

        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
        public int DepartmentID { get; set; }
        public int TeamID { get; set; }
        public int LocationID { get; set; }

    }
}