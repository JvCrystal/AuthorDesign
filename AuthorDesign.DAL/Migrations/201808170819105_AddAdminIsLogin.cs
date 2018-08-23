namespace AuthorDesign.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminIsLogin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "IsLogin", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "IsLogin");
        }
    }
}
