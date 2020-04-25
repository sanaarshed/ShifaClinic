namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BillProcedure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillProcedure()
        {
            BillProcedureDetails = new HashSet<BillProcedureDetail>();
        }

        public int id { get; set; }

        public int? billId { get; set; }

        public int? patientId { get; set; }

        public double gross { get; set; }

        public double discount { get; set; }

        public double? billAmount { get; set; }

        public double paid { get; set; }

        public double balance { get; set; }

        public int createdBy { get; set; }

        public DateTime createDate { get; set; }

        public int? modifiedBy { get; set; }

        public DateTime? modifyDate { get; set; }

        public virtual Bill Bill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillProcedureDetail> BillProcedureDetails { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
