using FitApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FitApp.DataAccessLayer
{
    public class ActivityContext : DbContext
    {
        public ActivityContext() : base("DefaultConnection")
            { }

        public DbSet<Activity> Activities { get; set; }
    }
}