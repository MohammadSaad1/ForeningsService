namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bolig")]
    public partial class Bolig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bolig()
        {
            Adresse = new HashSet<Adresse>();
            Beboer = new HashSet<Beboer>();
            Person = new HashSet<Person>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BoligID { get; set; }

        [StringLength(50)]
        public string Bolignummer { get; set; }

        [StringLength(1)]
        public string Boligtype { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AndelFra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AndelTil { get; set; }

        public double? M2 { get; set; }

        public int? AdresseID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adresse> Adresse { get; set; }

        public virtual Adresse Adresse1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Beboer> Beboer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> Person { get; set; }
    }
}
