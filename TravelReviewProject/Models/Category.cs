using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Category
    {//set as primary key//
        [Key]
        public int CatID { get; set; }
        [DisplayName("COUNTRY")]
        public string Country { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}