namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Opgaver")]
    public partial class Opgaver
    {
        [Key]
        public int OpgaveID { get; set; }

        [StringLength(50)]
        public string Opgave { get; set; }

        public int? PersonID { get; set; }

        public int? UnderaktivitetID { get; set; }

        public virtual Person Person { get; set; }

        public virtual Underaktivitet Underaktivitet { get; set; }
    }
}
