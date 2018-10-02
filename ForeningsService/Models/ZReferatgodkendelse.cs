namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZReferatgodkendelse")]
    public partial class ZReferatgodkendelse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReferatgodkendelseID { get; set; }

        public DateTime? Tidspunkt { get; set; }

        public int? PersonID { get; set; }

        public int? ReferatID { get; set; }
    }
}
