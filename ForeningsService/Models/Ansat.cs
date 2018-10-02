namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ansat")]
    public partial class Ansat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ansat()
        {
            Aktivitet = new HashSet<Aktivitet>();
            Person1 = new HashSet<Person>();
            Underaktivitet = new HashSet<Underaktivitet>();
        }

        public int AnsatID { get; set; }

        [StringLength(50)]
        public string Stilling { get; set; }

        [StringLength(10)]
        public string Initialer { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AnsatFra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AnsatTil { get; set; }

        public int? PersonID { get; set; }

        public int? ForeningID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aktivitet> Aktivitet { get; set; }

        public virtual Forening Forening { get; set; }

        public virtual Person Person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> Person1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Underaktivitet> Underaktivitet { get; set; }
    }
}
