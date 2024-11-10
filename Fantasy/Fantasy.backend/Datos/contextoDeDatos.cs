using Fantasy.Shared.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Fantasy.backend.Datos;

public class contextoDeDatos : DbContext
{
    public DbSet<Pais> Paices { get; set; }

    public contextoDeDatos(DbContextOptions<contextoDeDatos> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Pais>().HasIndex(x => x.nombre).IsUnique();
    }
}