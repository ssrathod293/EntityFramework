namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Mobile_To_Student : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblStudent", "Mobile", c => c.String(maxLength: 14));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblStudent", "Mobile");
        }
    }
}
