using BMS.Data.Helpers;
using BMS.Data.Models;
using System.Linq;

namespace BMS.Data
{
    public static class DbInitializer
    {
        public static void Seed(BMSDbContext context)
        {
            // Prevent seeding duplicate data
            if (context.USR_Users.Any()) return;

            var defaultUser = new USR_Users
            {
                Id = Guid.NewGuid().ToString(),
                LoginId = "Admin",
                UserName = "Administrator",
                Password = PasswordHelper.EncryptPassword("admin@123"), // Note: in production, use hashing!
                IsAdmin = true,
                IsDeleted = false,
            };

            context.USR_Users.Add(defaultUser);
            context.SaveChanges();
        }
    }
}

