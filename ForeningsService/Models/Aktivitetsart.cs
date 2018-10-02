namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aktivitetsart")]
    public partial class Aktivitetsart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aktivitetsart()
        {
            Aktivitetstype = new HashSet<Aktivitetstype>();
        }

        public int AktivitetsartID { get; set; }

        [Column("Aktivitetsart")]
        [StringLength(50)]
        public string Aktivitetsart1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aktivitetstype> Aktivitetstype { get; set; }
    }
}
