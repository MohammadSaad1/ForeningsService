namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Beboer")]
    public partial class Beboer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BeboerID { get; set; }

        [StringLength(1)]
        public string Beboertype { get; set; }

        public int? KontraktID { get; set; }

        public int? BoligID { get; set; }

        public virtual Bolig Bolig { get; set; }

        public virtual Kontrakt Kontrakt { get; set; }
    }
}
