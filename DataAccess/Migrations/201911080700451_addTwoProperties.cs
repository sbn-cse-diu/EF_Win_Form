namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTwoProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "City", c => c.String());
            AddColumn("dbo.Students", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Email");
            DropColumn("dbo.Students", "City");
        }
    }
}
