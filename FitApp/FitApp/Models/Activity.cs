using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitApp.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public DateTime Start_time { get; set; }
        public DateTime End_time { get; set; }
        public int RoomId { get; set; }
        public int CoachId { get; set; }

        public Coachs Coachs { get; set; }
        public Rooms Rooms { get; set; }

    }
}