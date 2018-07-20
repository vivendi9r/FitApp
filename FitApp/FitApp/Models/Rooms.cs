using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitApp.Models
{
    public class Rooms
    {
        public int RoomID { get; set; }
        public string name { get; set; }

        public ICollection<Activity> Activity { get; set; }

    }
}