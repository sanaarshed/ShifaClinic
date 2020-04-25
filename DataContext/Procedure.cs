namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Procedure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Procedure()
        {
            BillProcedureDetails = new HashSet<BillProcedureDetail>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string description { get; set; }

        public double price { get; set; }

        public int createdBy { get; set; }

        public DateTime createDate { get; set; }

        public int? modifiedBy { get; set; }

        public DateTime? modifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillProcedureDetail> BillProcedureDetails { get; set; }
    }
}
