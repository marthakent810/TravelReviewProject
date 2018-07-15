using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }
        [DisplayName("TITLE")]
        public string Title { get; set; }
        [DisplayName("REVIEW YOUR TRIP")]
        public string Content { get; set; }
        [DisplayName("TRIP DATE")]
        public string TripDate { get; set; }
        [DisplayName("RATING: ")]
        public int Stars { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}