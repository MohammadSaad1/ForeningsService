namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aktivitet")]
    public partial class Aktivitet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aktivitet()
        {
            Underaktivitet = new HashSet<Underaktivitet>();

        }

        public int AktivitetID { get; set; }

        [Column("Aktivitet")]
        [StringLength(50)]
        public string Aktivitet1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OprettelseDato { get; set; }

        public string Kommentar { get; set; }

        public string Reference { get; set; }

        public int? PersonID { get; set; }

        public int? AnsatID { get; set; }

        public int? AktivitetstypeID { get; set; }

        public virtual Aktivitetstype Aktivitetstype { get; set; }

        public virtual Ansat Ansat { get; set; }

        public virtual Person Person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Underaktivitet> Underaktivitet { get; set; }
    }
}
