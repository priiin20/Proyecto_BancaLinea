namespace WebAppBancaLinea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int pk_id_usuario { get; set; }

        [Column("usuario")]
        [Required]
        [StringLength(20)]
        public string usuario1 { get; set; }

        [Required]
        [StringLength(20)]
        public string contrasenia { get; set; }

        public int telefono { get; set; }

        [Required]
        [StringLength(20)]
        public string correo { get; set; }
    }
}
