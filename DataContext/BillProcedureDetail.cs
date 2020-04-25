namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BillProcedureDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillProcedureDetail()
        {
            ProcedureReturns = new HashSet<ProcedureReturn>();
        }

        public int id { get; set; }

        public int? billProcedureId { get; set; }

        public int procedureId { get; set; }

        public int doctorId { get; set; }

        public double actualPrice { get; set; }

        public double amount { get; set; }

        [StringLength(50)]
        public string discount { get; set; }

        public double? discountRate { get; set; }

        public bool isReturnFiled { get; set; }

        public virtual BillProcedure BillProcedure { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Procedure Procedure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcedureReturn> ProcedureReturns { get; set; }
    }
}
