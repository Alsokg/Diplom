namespace StudentMonitoringSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UniversityId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Universities", t => t.UniversityId)
                .Index(t => t.UniversityId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        FacultyId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId)
                .Index(t => t.FacultyId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SurName = c.String(),
                        StudentBookNumber = c.String(),
                        GroupId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Double(nullable: false),
                        MarkPointId = c.Int(),
                        StudentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MarkPoints", t => t.MarkPointId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.MarkPointId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.MarkPoints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SubjectId = c.Int(),
                        maxValue = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SurName = c.String(nullable: false),
                        Grade = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LectorSubjects",
                c => new
                    {
                        Lector_Id = c.Int(nullable: false),
                        Subject_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Lector_Id, t.Subject_Id })
                .ForeignKey("dbo.Lectors", t => t.Lector_Id, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id, cascadeDelete: true)
                .Index(t => t.Lector_Id)
                .Index(t => t.Subject_Id);
            
            CreateTable(
                "dbo.SubjectStudents",
                c => new
                    {
                        Subject_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_Id, t.Student_Id })
                .ForeignKey("dbo.Subjects", t => t.Subject_Id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Subject_Id)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faculties", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.Marks", "StudentId", "dbo.Students");
            DropForeignKey("dbo.SubjectStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.SubjectStudents", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.MarkPoints", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.LectorSubjects", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.LectorSubjects", "Lector_Id", "dbo.Lectors");
            DropForeignKey("dbo.Marks", "MarkPointId", "dbo.MarkPoints");
            DropForeignKey("dbo.Students", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Groups", "FacultyId", "dbo.Faculties");
            DropIndex("dbo.SubjectStudents", new[] { "Student_Id" });
            DropIndex("dbo.SubjectStudents", new[] { "Subject_Id" });
            DropIndex("dbo.LectorSubjects", new[] { "Subject_Id" });
            DropIndex("dbo.LectorSubjects", new[] { "Lector_Id" });
            DropIndex("dbo.MarkPoints", new[] { "SubjectId" });
            DropIndex("dbo.Marks", new[] { "StudentId" });
            DropIndex("dbo.Marks", new[] { "MarkPointId" });
            DropIndex("dbo.Students", new[] { "GroupId" });
            DropIndex("dbo.Groups", new[] { "FacultyId" });
            DropIndex("dbo.Faculties", new[] { "UniversityId" });
            DropTable("dbo.SubjectStudents");
            DropTable("dbo.LectorSubjects");
            DropTable("dbo.Universities");
            DropTable("dbo.Lectors");
            DropTable("dbo.Subjects");
            DropTable("dbo.MarkPoints");
            DropTable("dbo.Marks");
            DropTable("dbo.Students");
            DropTable("dbo.Groups");
            DropTable("dbo.Faculties");
        }
    }
}
