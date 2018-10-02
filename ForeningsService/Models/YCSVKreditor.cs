namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YCSVKreditor")]
    public partial class YCSVKreditor
    {
        [Key]
        [Column("_Id_", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_Id_ { get; set; }

        [Key]
        [Column("_Navn_", Order = 1)]
        [StringLength(50)]
        public string C_Navn_ { get; set; }

        [Column("_Email_")]
        [StringLength(50)]
        public string C_Email_ { get; set; }

        [Key]
        [Column("_Nummer_", Order = 2)]
        [StringLength(50)]
        public string C_Nummer_ { get; set; }

        [Column("_TelefonNrPrivat_")]
        [StringLength(50)]
        public string C_TelefonNrPrivat_ { get; set; }

        [Column("_MobilNr_")]
        [StringLength(50)]
        public string C_MobilNr_ { get; set; }

        [Key]
        [Column("_Adresse_", Order = 3)]
        [StringLength(50)]
        public string C_Adresse_ { get; set; }

        [Key]
        [Column("_PostNr_", Order = 4)]
        [StringLength(50)]
        public string C_PostNr_ { get; set; }

        [Key]
        [Column("_PostBy_", Order = 5)]
        [StringLength(50)]
        public string C_PostBy_ { get; set; }

        [Column("_CvrNr_")]
        [StringLength(50)]
        public string C_CvrNr_ { get; set; }
    }
}
