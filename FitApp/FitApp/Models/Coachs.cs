using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitApp.Models
{
    public class Coachs
    {
        public int CoachId { get; set; }
        public int UserId { get; set; } 

        public ICollection<Activity> Activity { get; set; }
    }
}