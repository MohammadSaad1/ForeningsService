namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aktivitetdeltager")]
    public partial class Aktivitetdeltager
    {
        public int AktivitetdeltagerID { get; set; }

        public int? StatusID { get; set; }

        public int? PersonID { get; set; }

        public int? UnderaktivitetID { get; set; }

        public virtual Person Person { get; set; }

        public virtual Status Status { get; set; }

        public virtual Underaktivitet Underaktivitet { get; set; }
    }
}
