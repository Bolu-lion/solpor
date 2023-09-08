using Microsoft.EntityFrameworkCore;
using SolutionPortalBeta.Server.Models;
using System;

namespace SolutionPortalBeta.Server.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {

        static readonly string connectionString = "Server=localhost; User ID=root; Database=solpor;Password=kayode";
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<UserComplaint> UserComplaints { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FAQ>();
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
