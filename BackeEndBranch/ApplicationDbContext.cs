using BackeEndBranch.Models;
using Microsoft.EntityFrameworkCore;

namespace BackeEndBranch
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<Coin> Coins { get; set; }
    }
}
