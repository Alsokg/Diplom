using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    

    public class UniversityContext: DbContext
    {
        public UniversityContext()
            : base("UniversityConnection")
        { }
        public DbSet<University> University { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Lector> Lector { get; set; }
        public DbSet<MarkPoint> MarkPoint { get; set; }
        public DbSet<Mark> Mark { get; set; }

    }
}