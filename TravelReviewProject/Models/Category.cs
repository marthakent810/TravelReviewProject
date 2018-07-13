﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Category
    {
        [Key]
        public int CatID { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}