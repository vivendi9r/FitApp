using FitApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<IdentityUserRole>().ToTable("AspNetRoles");
            //modelBuilder.Entity<IdentityUserLogin>().ToTable("AspNetUserLogins");
        }
    }
}