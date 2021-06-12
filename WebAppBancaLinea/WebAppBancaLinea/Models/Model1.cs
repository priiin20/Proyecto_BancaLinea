namespace WebAppBancaLinea.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .Property(e => e.usuario1)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.contrasenia)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.correo)
                .IsFixedLength();
        }
    }
}
