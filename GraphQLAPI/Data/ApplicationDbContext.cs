using GraphQLAPI.Data.ContextConfigurations;
using Microsoft.EntityFrameworkCore;

namespace GraphQLAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Superhero> Superheroes { get; set; }
    public DbSet<Superpower> Superpowers { get; set; }
    public DbSet<Movie> Movies { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        var ids = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
        builder.ApplyConfiguration(new SuperheroContextConfiguration(ids));
        builder.ApplyConfiguration(new SuperpowerContextConfiguration(ids));
        builder.ApplyConfiguration(new MovieContextConfiguration(ids));
    }
}