using Microsoft.EntityFrameworkCore;
using LogicaDeNegocio.Entidades;

namespace AccesoADatos
{
    public class Contexto : DbContext
    {
        public DbSet<Billetera> Billetera { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Concepto> Concepto { get; set; }
        public DbSet<Etiqueta> Etiqueta { get; set; }
        public DbSet<Movimiento> Movimiento { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public Contexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(usuario => usuario.HasKey(u => u.Id));
            modelBuilder.Entity<Billetera>(billetera => billetera.HasKey(b => b.Id));
            modelBuilder.Entity<Categoria>(categoria => categoria.HasKey(c => c.Id));
            modelBuilder.Entity<Concepto>(concepto => concepto.HasKey(c => c.Id));
            modelBuilder.Entity<Etiqueta>(etiqueta => etiqueta.HasKey(e => e.Id));
            modelBuilder.Entity<Movimiento>(movimiento => movimiento.HasKey(m => m.Id));

            base.OnModelCreating(modelBuilder);
        }
    }
}
