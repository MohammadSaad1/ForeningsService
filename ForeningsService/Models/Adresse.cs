namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adresse")]
    public partial class Adresse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adresse()
        {
            Bolig1 = new HashSet<Bolig>();
            Forening = new HashSet<Forening>();
            Person1 = new HashSet<Person>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdresseID { get; set; }

        [Column("Adresse")]
        [StringLength(50)]
        public string Adresse1 { get; set; }

        [StringLength(10)]
        public string Landekode { get; set; }

        public int? Postnr { get; set; }

        public int? PersonID { get; set; }

        public int? BoligID { get; set; }

        public virtual Bolig Bolig { get; set; }

        public virtual Person Person { get; set; }

        public virtual PostnrBy PostnrBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bolig> Bolig1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Forening> Forening { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> Person1 { get; set; }
    }
}
