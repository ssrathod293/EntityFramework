namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedtrainermodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        TrainerId = c.Int(nullable: false, identity: true),
                        TrainerName = c.String(),
                        Experience = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrainerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trainers");
        }
    }
}
