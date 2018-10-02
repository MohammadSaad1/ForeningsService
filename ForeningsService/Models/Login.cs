namespace ForeningsService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Login()
        {
            Person1 = new HashSet<Person>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LoginID { get; set; }

        public int? RettighederID { get; set; }

        public int? PersonID { get; set; }

        public virtual Person Person { get; set; }

        public virtual Rettigheder Rettigheder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> Person1 { get; set; }
    }
}
