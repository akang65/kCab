namespace kCab.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using kCab.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<kCab.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "kCab.Models.ApplicationDbContext";
        }

        protected override void Seed(kCab.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var manager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(
                    new ApplicationDbContext()));
            // Create 4 test users:
            //for (int i = 0; i < 4; i++)
            //{
            //    var user = new ApplicationUser()
            //    {
            //        UserName = string.Format("User{0}", i.ToString()),

            //        // Add the following so our Seed data is complete:
            //        Name = string.Format("FirstName{0}", i.ToString()),
            //        LastName = string.Format("LastName{0}", i.ToString()),
            //        Email = string.Format("Email{0}@Example.com", i.ToString()),
            //    };
            //    manager.Create(user, string.Format("Password{0}", i.ToString()));
            //}
        }
    }
}   