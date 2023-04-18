namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblStudent",
                c => new
                    {
                        RollNumber = c.Int(nullable: false, identity: true),
                        StudentName = c.String(maxLength: 8000, unicode: false),
                        Gender = c.String(maxLength: 10, unicode: false),
                        Email = c.String(nullable: false, maxLength: 200),
                        City = c.String(nullable: false, maxLength: 50),
                        Fees = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.RollNumber)
                .Index(t => t.Fees, name: "Ix_Student_Fees");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.tblStudent", "Ix_Student_Fees");
            DropTable("dbo.tblStudent");
        }
    }
}
