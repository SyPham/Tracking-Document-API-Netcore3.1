using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class History : EntityBase<int>
    {
        public bool Sent { get; set; }
        public bool Alert { get; set; }

    }
}