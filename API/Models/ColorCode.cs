using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class ColorCode: EntityBase<int>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string CssCode { get; set; }
    }
}