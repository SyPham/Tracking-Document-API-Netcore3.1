using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Notifications : EntityBase<int>
    {
        public Notifications()
        {
            this.CreatedDate = DateTime.Now;
        }
     
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public int RecordID { get; set; }

        public int UserID { get; set; }

        public string Action { get; set; }

        public string LanguageID { get; set; }

        public virtual List<NotificationDetail> NotificationDetails { get; set; }
    }
}