﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StarkStateCollege.Models; //Needed to see the 3 models, use your project name
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StarkStateCollege.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}