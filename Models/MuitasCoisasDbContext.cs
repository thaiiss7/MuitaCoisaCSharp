using Microsoft.EntityFrameworkCore;

namespace MuitaCoisaCSharp.Models;

public class MuitasCoisasDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Day> Days => Set<Day>();
    public DbSet<Diva> Divas => Set<Diva>();

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Day>();

        model.Entity<Diva>()
            .HasMany(d => d.Days)
            .WithMany(d => d.Divas)
            .UsingEntity(j => j.ToTable("DayDiva"));
    }
}