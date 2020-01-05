using DataBaseLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBaseLibrary
{
    public sealed class AdminContext : DbContext
    {
        public AdminContext()
        {
            Database.EnsureCreated();
        }
        public AdminContext(DbContextOptions<CandidateContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<DataBaseLibrary.Models.AdminAccount> AdminAccounts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=ISCARNETadmin;Trusted_Connection=True");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
