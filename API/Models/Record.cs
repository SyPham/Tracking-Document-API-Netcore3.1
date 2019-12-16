using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Record : EntityBase<int>
    {
        public Record()
        {
            this.CreatedDate = DateTime.Now;
            Modifieddate = DateTime.Now;
        }

        public DateTime CreatedDate
        {
            get;
            set;
        }

        public int CategoryID { get; set; }

        public int SubCategoryID { get; set; }

        public string Description { get; set; }

        public int UserID { get; set; }

        public int LocationID { get; set; }

        public string Title { get; set; }

        public int StatusID { get; set; }

        public int TeamID { get; set; }

        public int DepartmentID { get; set; }

        public DateTime Modifieddate { get; set; }

        public string TrackingID { get; set; }

        public int DepartmentHeadID { get; set; }

        public string LanguageID { get; set; }

        public int ColorCodeID { get; set; }
        public bool State { get; set; }
    }
}