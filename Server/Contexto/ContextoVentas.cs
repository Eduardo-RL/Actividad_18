using Actividad_18.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Actividad_18.Server.Contexto
{
    public class ContextoVentas : DbContext
    {
        public ContextoVentas(DbContextOptions<ContextoVentas> options) : base(options) 
        {
            
        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
    }
}
