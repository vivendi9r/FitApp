﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitApp.Models
{
    public class Coachs
    {
        [Key]
        public int CoachId { get; set; }
        public int UserId { get; set; } 

        public ICollection<Activity> Activity { get; set; }
    }
}