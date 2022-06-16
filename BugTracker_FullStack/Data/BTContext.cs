using BugTracker_FullStack.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTracker_FullStack.Data
{
    public class BTContext : DbContext
    {
        public BTContext(DbContextOptions<BTContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Company> Companys { get; set; }
    }
}
