namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Samarbejdsfirma")]
    public partial class Samarbejdsfirma
    {
        public int SamarbejdsfirmaID { get; set; }

        [StringLength(50)]
        public string Firmanavn { get; set; }

        [StringLength(100)]
        public string Firmaadresse { get; set; }

        public int? Postnr { get; set; }

        public int? CVRnr { get; set; }

        public int? Telefon { get; set; }

        public int? Mobilnr { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public virtual PostnrBy PostnrBy { get; set; }
    }
}
