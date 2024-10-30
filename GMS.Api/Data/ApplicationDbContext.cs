using Microsoft.EntityFrameworkCore;
using YourNamespace.Models; // Replace with your actual namespace

namespace GMS.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Grant> Grants { get; set; }
        public DbSet<GrantApplication> GrantApplications { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Grant> Grants { get; set; }
        public DbSet<Milestone> Milestones { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        // Add other DbSets for each entity like Users, Applications, etc.
    }
}
