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
            : base("DefaultConnection")
        { }
        public DbSet<University> Universities { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Lector> Lectors { get; set; }
        public DbSet<MarkPoint> MarkPoints { get; set; }
        public DbSet<Mark> Marks { get; set; }

    }
}