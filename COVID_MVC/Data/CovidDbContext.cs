using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using COVID_MVC.Models.Entities;

namespace COVID_MVC.Data
{
    public class CovidDbContext:DbContext
    {
        public DbSet<Area> Areas { get; set; }
        
        public DbSet<Town> Towns { get; set; }

        public DbSet<Sick> Sicks { get; set; }

        public DbSet<Volunteer> Volunteers { get; set; }
    }
}