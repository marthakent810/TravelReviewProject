﻿using System;
using System.Collections.Generic;
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
        public string Title { get; set; }
        public string Content { get; set; }
        public string TripDate { get; set; }
        public int Stars { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}