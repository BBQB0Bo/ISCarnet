using DataBaseLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBaseLibrary
{
    public sealed class CandidateContext : DbContext
    {
        public CandidateContext()
        {
            Database.EnsureCreated();
        }
        public CandidateContext(DbContextOptions<CandidateContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Examinator> Examinators { get; set; }

        public DbSet<Mistake> Mistakes { get; set; }

        public DbSet<Location> Locations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                    => optionsBuilder
    .UseLazyLoadingProxies()
    .UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=ISCARNET;Trusted_Connection=True");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                .HasOne(c => c.UserAccount)
                .WithOne(a => a.AccountOwner)
                .HasForeignKey<Account>(a => a.CandidateForeignKey);
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Candidate)
                .WithMany(c => c.PastExams);

            modelBuilder.Entity<Mistake>()
                .HasOne(m => m.Exam)
                .WithMany(e => e.Mistakes);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Examinator)
                .WithMany(c => c.Exams);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Location)
                .WithMany(l => l.Exams);

            modelBuilder.Entity<Candidate>()
                .Property(C => C.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Candidate>()
                .Property(C => C.LastName)
                .IsRequired()
                .HasMaxLength(30);
            modelBuilder.Entity<Examinator>()
                .Property(E => E.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Examinator>()
                .Property(E => E.LastName)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Candidate>()
                .Property(E => E.CNP)
                .IsRequired().HasMaxLength(13);
            modelBuilder.Entity<Candidate>()
                .Property(C => C.BirthDate)
                .IsRequired();

        }
    }
}
