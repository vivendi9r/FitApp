using FitApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FitApp.DataAccessLayer
{
    public class GymContext : DbContext
    {
        public GymContext() : base("DefaultConnection")
            { }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Coachs> Coachs { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<ActivitiesUsers> ActivitiesUsers  { get; set; }
    }
}