namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            BillDetails = new HashSet<BillDetail>();
            BillProcedures = new HashSet<BillProcedure>();
            ServiceReturns = new HashSet<ServiceReturn>();
        }

        public int id { get; set; }

        public int patientId { get; set; }

        public double? gross { get; set; }

        public double? discount { get; set; }

        public double? billAmount { get; set; }

        public double? paid { get; set; }

        public double? balance { get; set; }

        public int createdBy { get; set; }

        public DateTime createDate { get; set; }

        public int? modifiedBy { get; set; }

        public DateTime? modifyDate { get; set; }

        [StringLength(1000)]
        public string remarks { get; set; }

        public int? tokenNumber { get; set; }

        public int? bloodPressureUpper { get; set; }

        public int? bloodPressureLower { get; set; }

        public int? patientAge { get; set; }

        public int? patientHeight { get; set; }

        public int? patientWeight { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillProcedure> BillProcedures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceReturn> ServiceReturns { get; set; }
    }
}
