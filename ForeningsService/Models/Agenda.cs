namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Agenda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agenda()
        {
            Referat1 = new HashSet<Referat>();
        }

        public int AgendaID { get; set; }

        public int? Punktnummer { get; set; }

        public string Punktoverskrift { get; set; }

        public string Punktbeskrivelse { get; set; }

        public string Punktreferat { get; set; }

        public byte[] Bilag { get; set; }

        public int? PersonID { get; set; }

        public int? OpfølgningID { get; set; }

        public int? UnderaktivitetID { get; set; }

        public int? ReferatID { get; set; }

        public virtual Opfølgning Opfølgning { get; set; }

        public virtual Person Person { get; set; }

        public virtual Referat Referat { get; set; }

        public virtual Underaktivitet Underaktivitet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referat> Referat1 { get; set; }
    }
}
