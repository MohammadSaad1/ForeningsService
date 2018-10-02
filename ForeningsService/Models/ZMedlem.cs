namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZMedlem")]
    public partial class ZMedlem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MedlemID { get; set; }

        public int? Medlem { get; set; }

        public int? ForeningID { get; set; }
    }
}
