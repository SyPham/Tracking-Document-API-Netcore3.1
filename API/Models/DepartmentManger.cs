using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class DepartmentManger : EntityBase<int>
    {
        public int UserID { get; set; }
        public int DepartmentID { get; set; }
    }
}