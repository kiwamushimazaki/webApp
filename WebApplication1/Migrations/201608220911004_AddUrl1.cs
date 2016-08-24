namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "UserName", c => c.String());
            DropColumn("dbo.Members", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "Email", c => c.String());
            DropColumn("dbo.Members", "UserName");
        }
    }
}
