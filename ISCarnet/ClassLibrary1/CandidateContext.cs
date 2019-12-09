using Microsoft.EntityFrameworkCore;

namespace DataBaseLibrary
{
    public sealed class CandidateContext : DbContext
    {
        public CandidateContext(DbContextOptions<CandidateContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Exam> Exams { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                .HasOne(c => c.UserAccount)
                .WithOne(a => a.AccountOwner)
                .HasForeignKey<Account>(a => a.CandidateForeignKey);
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Candidate)
                .WithMany(c => c.PastExams);


            modelBuilder.Entity<Candidate>()
                .Property(C => C.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Candidate>()
                .Property(C => C.LastName)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Candidate>()
                .Property(C => C.CNP)
                .IsRequired().HasMaxLength(13);
            modelBuilder.Entity<Candidate>()
                .Property(C => C.BirthDate)
                .IsRequired();

        }
    }
}
