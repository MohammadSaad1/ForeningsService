namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Forening")]
    public partial class Forening
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Forening()
        {
            Ansat = new HashSet<Ansat>();
            Kontrakt = new HashSet<Kontrakt>();
        }

        public int ForeningID { get; set; }

        [Column("Forening")]
        [StringLength(50)]
        public string Forening1 { get; set; }

        public double? m2Pris { get; set; }

        public int? AdresseID { get; set; }

        public int? AnsatID { get; set; }

        public virtual Adresse Adresse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ansat> Ansat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kontrakt> Kontrakt { get; set; }
    }
}
