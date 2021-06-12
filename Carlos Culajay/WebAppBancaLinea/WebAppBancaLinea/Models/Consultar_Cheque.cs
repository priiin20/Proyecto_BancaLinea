namespace WebAppBancaLinea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Consultar_Cheque
    {
        [Key]
        public int fk_id_consultar_cheque { get; set; }

        [Required]
        [StringLength(50)]
        public string no_cheque { get; set; }

        [Required]
        [StringLength(50)]
        public string cuenta { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public double cantidad { get; set; }
    }
}
