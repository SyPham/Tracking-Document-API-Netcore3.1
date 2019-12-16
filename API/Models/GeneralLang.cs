using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public abstract class GeneralLang : EntityBase<string>
    {
        public string Name { get; set; }
        public string LanguageID { get; set; }
    }
}