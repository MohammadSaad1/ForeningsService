namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Underaktivitet")]
    public partial class Underaktivitet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Underaktivitet()
        {
            Agenda = new HashSet<Agenda>();
            Aktivitetdeltager = new HashSet<Aktivitetdeltager>();
            Besked = new HashSet<Besked>();
            Opfølgning = new HashSet<Opfølgning>();
            Opgaver = new HashSet<Opgaver>();
        }

        public int UnderaktivitetID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UnderaktivitetDato { get; set; }

        public TimeSpan? AktivitetStart { get; set; }

        public TimeSpan? AktivitetSlut { get; set; }

        public bool? Primær { get; set; }

        [StringLength(100)]
        public string Sted { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] MTTS { get; set; }

        public string Kommentar { get; set; }

        public int? OpfølgningID { get; set; }

        public int? AnsatID { get; set; }

        public int? AktivitetID { get; set; }

        public int? UnderaktivitetstypeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agenda> Agenda { get; set; }

        public virtual Aktivitet Aktivitet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aktivitetdeltager> Aktivitetdeltager { get; set; }

        public virtual Ansat Ansat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Besked> Besked { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opfølgning> Opfølgning { get; set; }

        public virtual Opfølgning Opfølgning1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opgaver> Opgaver { get; set; }

        public virtual Underaktivitetstype Underaktivitetstype { get; set; }
    }
}
