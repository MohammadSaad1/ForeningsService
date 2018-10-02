namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Adresse = new HashSet<Adresse>();
            Agenda = new HashSet<Agenda>();
            Aktivitet = new HashSet<Aktivitet>();
            Aktivitetdeltager = new HashSet<Aktivitetdeltager>();
            Ansat = new HashSet<Ansat>();
            Besked = new HashSet<Besked>();
            Kontrakt = new HashSet<Kontrakt>();
            Login = new HashSet<Login>();
            Opfølgning = new HashSet<Opfølgning>();
            Opgaver = new HashSet<Opgaver>();
            Referat = new HashSet<Referat>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonID { get; set; }

        [StringLength(10)]
        public string Køn { get; set; }

        [StringLength(50)]
        public string Fornavn { get; set; }

        [StringLength(50)]
        public string Efternavn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fødselsdato { get; set; }

        public int? SSNO { get; set; }

        public int? Mobil { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OprettetDato { get; set; }

        public string Note { get; set; }

        [StringLength(50)]
        public string Brugernavn { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public bool? ReferatEmail { get; set; }

        public int? LoginID { get; set; }

        public int? AdresseID { get; set; }

        public int? AnsatID { get; set; }

        public int? BoligID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adresse> Adresse { get; set; }

        public virtual Adresse Adresse1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agenda> Agenda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aktivitet> Aktivitet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aktivitetdeltager> Aktivitetdeltager { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ansat> Ansat { get; set; }

        public virtual Ansat Ansat1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Besked> Besked { get; set; }

        public virtual Bolig Bolig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kontrakt> Kontrakt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Login> Login { get; set; }

        public virtual Login Login1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opfølgning> Opfølgning { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opgaver> Opgaver { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referat> Referat { get; set; }
    }
}
