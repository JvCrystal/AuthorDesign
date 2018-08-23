namespace AuthorDesign.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_AdminOperation_IsSuperAdmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminOperations", "IsSuperAdmin", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdminOperations", "IsSuperAdmin");
        }
    }
}
