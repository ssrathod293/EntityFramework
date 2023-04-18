namespace CodeFirstUsingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_courses_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                {
                    CourseId = c.Int(nullable: false, identity: true),
                    CourseName = c.String(),
                    Duration = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.CourseId);

        }
        public override void Down()
        {
            DropTable("dbo.Courses");
        }
    }
}
