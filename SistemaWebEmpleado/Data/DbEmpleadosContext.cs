using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;

namespace SistemaWebEmpleado.Data
{
    
        public class DbEmpleadosContext : DbContext
        {
            public DbEmpleadosContext(DbContextOptions options) : base(options)
            {
            }
            public DbSet<Empleado> Empleados { get; set; }
        }
    
}
