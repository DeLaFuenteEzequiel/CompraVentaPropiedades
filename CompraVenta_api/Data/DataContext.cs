using CompraVenta_api.Models;
using Microsoft.EntityFrameworkCore;

namespace CompraVenta_api.Data
{
    public class DataContext : DbContext
    {
            public DataContext(DbContextOptions<DataContext> options) 
            : base (options)
            {
                
            }

            public DbSet<Propiedad> Propiedades{get; set;}
            public DbSet<Usuario> Usuarios{get; set;}
    }
}