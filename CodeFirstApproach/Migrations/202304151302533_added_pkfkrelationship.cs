namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_pkfkrelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblStudent", "TrainerId", c => c.Int());
            CreateIndex("dbo.tblStudent", "TrainerId");
            AddForeignKey("dbo.tblStudent", "TrainerId", "dbo.Trainers", "TrainerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblStudent", "TrainerId", "dbo.Trainers");
            DropIndex("dbo.tblStudent", new[] { "TrainerId" });
            DropColumn("dbo.tblStudent", "TrainerId");
        }
    }
}
