namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kreditorliste")]
    public partial class Kreditorliste
    {
        [StringLength(50)]
        public string FirmaNavn { get; set; }

        [StringLength(50)]
        public string Nummer { get; set; }

        [StringLength(50)]
        public string Telefon { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string MobilNr { get; set; }

        [StringLength(50)]
        public string Adresse { get; set; }

        public int? PostNr { get; set; }

        [StringLength(50)]
        public string PostBy { get; set; }

        [StringLength(50)]
        public string CvrNr { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
    }
}
