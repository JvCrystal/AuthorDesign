namespace AuthorDesign.DAL.Migrations
{
    using AuthorDesign.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AuthorDesign.DAL.AuthorDesignContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AuthorDesign.DAL.AuthorDesignContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            context.Admins.AddOrUpdate(
                p => p.AdminName,
                new Admin() { AdminName = "admin", CreateTime = DateTime.Now, IsLogin = 1, Salt = "1234567890", Password = "42C224B3C8899047460F5A6D1C041411", LastLoginAddress = "���л�", LastLoginIp = "192.168.0.1", LastLoginTime = DateTime.Now, IsSuperAdmin = 1 }
          );

        }
    }
}
