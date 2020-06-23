namespace Lab04.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Courses", "LecturerID");
            CreateIndex("dbo.Courses", "CategoryID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "CategoryID" });
            DropIndex("dbo.Courses", new[] { "LecturerID" });
            DropColumn("dbo.Courses", "IsCanceled");
            CreateIndex("dbo.Courses", "CategoryId");
            CreateIndex("dbo.Courses", "LecturerId");
        }
    }
}
