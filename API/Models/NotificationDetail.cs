using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class NotificationDetail : EntityBase<int>
    {
        public NotificationDetail()
        {
            this.CreatedDate = DateTime.Now;
        }


        public DateTime CreatedDate { get; set; }

        public int UserID { get; set; }

        public bool Sent { get; set; }
        public bool Seen { get; set; }
        public int NotificationID { get; set; }

        [ForeignKey("NotificationID")]
        public virtual Notifications Notification { get; set; }
    }
}