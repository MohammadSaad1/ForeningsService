namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aktivitetstype")]
    public partial class Aktivitetstype
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aktivitetstype()
        {
            Aktivitet = new HashSet<Aktivitet>();
        }

        public int AktivitetstypeID { get; set; }

        [Column("Aktivitetstype")]
        [StringLength(50)]
        public string Aktivitetstype1 { get; set; }

        [StringLength(50)]
        public string NextStepType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NextStepDag { get; set; }

        [StringLength(50)]
        public string DefaultUnderaktivitet { get; set; }

        public int? AktivitetsartID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aktivitet> Aktivitet { get; set; }

        public virtual Aktivitetsart Aktivitetsart { get; set; }
    }
}
