namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZMøde
    {
        [Key]
        public int MødeID { get; set; }

        [StringLength(50)]
        public string Mødetype { get; set; }

        public int? OpfølgningID { get; set; }
    }
}
