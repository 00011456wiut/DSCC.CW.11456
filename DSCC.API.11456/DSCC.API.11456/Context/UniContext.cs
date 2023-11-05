using DSCC.API._11456.Models;
using Microsoft.EntityFrameworkCore;

namespace DSCC.API._11456.Context
{
	public class UniContext: DbContext
    {
        public UniContext(DbContextOptions<UniContext> options) : base(options)
        {
        }

        // Database Tables
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<University> Universities { get; set; }
    }
}

