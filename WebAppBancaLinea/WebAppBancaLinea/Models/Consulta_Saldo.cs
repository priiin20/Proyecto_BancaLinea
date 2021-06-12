namespace WebAppBancaLinea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Consulta_Saldo
    {
        [Key]
        public int pk_id_Consulta_saldo { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_cuenta { get; set; }

        public double saldo_disponible { get; set; }

        public double saldo_reserva { get; set; }

        public double saldo_flotante { get; set; }

        public double saldo_total { get; set; }
    }
}
