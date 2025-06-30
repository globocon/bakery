using Microsoft.EntityFrameworkCore;
using BMS.Data.Models;

#nullable disable

namespace BMS.Data
{
    public class BMSDbContext : DbContext
    {
        public BMSDbContext(DbContextOptions<BMSDbContext> options) : base(options)
        {

        }

        public DbSet<USR_Users> USR_Users { get; set; }       
        
    }
   
}
