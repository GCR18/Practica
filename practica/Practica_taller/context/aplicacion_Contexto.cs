using Microsoft.EntityFrameworkCore;
using Practica_taller.Modelos;

namespace Practica_taller.context
{
    public class aplicacion_Context : DbContext
    {
        public aplicacion_Context
            (DbContextOptions<aplicacion_Context> options)
            : base(options) { }

        public DbSet<estudiante> Estudiantes { get; set; }
        public DbSet<docente> Docentes { get; set; }
        public DbSet<universidad> Universidades { get; set; }
    }
}
