using Microsoft.EntityFrameworkCore;
using WorkforceHub.Domain.Entities;
namespace WorkforceHub.Infrastructure.Persistence.Context;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Contractor> Contractors => Set<Contractor>();

    public DbSet<Company> Companies => Set<Company>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}