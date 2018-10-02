namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Underaktivitetstype")]
    public partial class Underaktivitetstype
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Underaktivitetstype()
        {
            Underaktivitet = new HashSet<Underaktivitet>();
        }

        public int UnderaktivitetstypeID { get; set; }

        [Column("Underaktivitetstype")]
        [StringLength(50)]
        public string Underaktivitetstype1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Underaktivitet> Underaktivitet { get; set; }
    }
}
