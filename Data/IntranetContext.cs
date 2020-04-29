using Microsoft.EntityFrameworkCore;
using Ihc.Models;

namespace Ihc.Data
{
    public class IntranetContext : DbContext
    {
        public IntranetContext (DbContextOptions<IntranetContext> options)
            : base(options)
        {
        }

        public DbSet<Contacto> Contacto { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Solicitud> Solicitud { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
