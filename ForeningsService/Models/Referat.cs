namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Referat")]
    public partial class Referat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Referat()
        {
            Agenda = new HashSet<Agenda>();
        }

        public int ReferatID { get; set; }

        [Column("Referat")]
        public string Referat1 { get; set; }

        public int? OpfølgningID { get; set; }

        public int? PersonID { get; set; }

        public int? AgendaID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agenda> Agenda { get; set; }

        public virtual Agenda Agenda1 { get; set; }

        public virtual Opfølgning Opfølgning { get; set; }

        public virtual Person Person { get; set; }
    }
}
