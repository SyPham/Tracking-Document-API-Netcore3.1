﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Menu : EntityBase<int>
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string FontawareSome { get; set; }
        public int RoleID { get; set; }
        public int Index { get; set; }
        public virtual Role Role { get; set; }
    }
}