using Microsoft.EntityFrameworkCore;
using OdevUc.Data.Domain;

namespace OdevUc.Data.Context;

public class OdevDbContext : DbContext
{
   
    public OdevDbContext(DbContextOptions<OdevDbContext> options) : base(options)
    {
    }
    
    public OdevDbContext()
    {
    }
    
    public DbSet<Product> Product { get; set; }
    public DbSet<Category> Category { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}