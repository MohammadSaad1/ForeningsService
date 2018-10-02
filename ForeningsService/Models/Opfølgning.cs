namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Opfølgning
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Opfølgning()
        {
            Agenda = new HashSet<Agenda>();
            Referat = new HashSet<Referat>();
            Underaktivitet1 = new HashSet<Underaktivitet>();
        }

        public int OpfølgningID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Opfølgningdato { get; set; }

        [StringLength(50)]
        public string Opfølgningstatus { get; set; }

        public int? PersonID { get; set; }

        public int? UnderaktivitetID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agenda> Agenda { get; set; }

        public virtual Person Person { get; set; }

        public virtual Underaktivitet Underaktivitet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referat> Referat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Underaktivitet> Underaktivitet1 { get; set; }
    }
}
