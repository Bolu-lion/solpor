using Microsoft.EntityFrameworkCore;
using SolutionPortalBeta.Server.Models;
using System;

namespace SolutionPortalBeta.Server.AppDbContext
{
	public class ApplicationDbContext : DbContext
	{
		
			public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
			public DbSet<UserComplaint>  UserComplaints { get; set; }
			public DbSet<FAQ> FAQs { get; set; }
			public DbSet<Company> Companies { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<FAQ>();
			base.OnModelCreating(modelBuilder);
        }
    }
}
