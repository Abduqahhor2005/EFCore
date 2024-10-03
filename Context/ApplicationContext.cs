using EFCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Context;

public sealed class ApplicationContext : DbContext
{
    // public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
    // {}
    public ApplicationContext()
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<User> Users { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql("Host=localhost;Database=ef_db;Username=postgres;Port=4321;Password=salom;");
}