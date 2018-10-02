namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kontrakt")]
    public partial class Kontrakt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kontrakt()
        {
            Beboer = new HashSet<Beboer>();
        }

        public int KontraktID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KontraktFra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KontraktTil { get; set; }

        [Column("Kontrakt")]
        public byte[] Kontrakt1 { get; set; }

        public int? PersonID { get; set; }

        public int? ForeningID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Beboer> Beboer { get; set; }

        public virtual Forening Forening { get; set; }

        public virtual Person Person { get; set; }
    }
}
