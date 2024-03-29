﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Common : EntityBase<int>
    {
        public Common()
        {
            ModifiedDate = DateTime.Now;
        }

        public string TrackingID { get; set; }
        public int DocumentCategory { get; set; }
        public int ApprovalSheetCategory { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int Location { get; set; }
        public int Department { get; set; }
        public int Team { get; set; }
        public string Username { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}