namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Besked")]
    public partial class Besked
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BeskedID { get; set; }

        [StringLength(100)]
        public string Overskrift { get; set; }

        [Column("Besked")]
        public string Besked1 { get; set; }

        public DateTime? Dato { get; set; }

        public int? PersonID { get; set; }

        public int? UnderaktivitetID { get; set; }

        public virtual Person Person { get; set; }

        public virtual Underaktivitet Underaktivitet { get; set; }
    }
}
