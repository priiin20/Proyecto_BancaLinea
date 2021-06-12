namespace WebAppBancaLinea.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model3")
        {
        }

        public virtual DbSet<Consultar_Cheque> Consultar_Cheque { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
