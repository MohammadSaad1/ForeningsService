namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YCSVBoende")]
    public partial class YCSVBoende
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Nummer { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Navn { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Adresse { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string PostBY { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "datetime2")]
        public DateTime Indflytningsdato { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Telefon { get; set; }
    }
}
