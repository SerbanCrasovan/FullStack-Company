using BackEndCompany.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndCompany.Data
{
    public class BackEndCompanyContext : DbContext
    {
        public DbSet<Company> Companies { get; set; } = null;

        public DbSet<Comments> Comments { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=companiesdb;Username=postgres;Password=postgres");
        }
    }
}
