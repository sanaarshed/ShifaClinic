namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProcedureReturn
    {
        public int id { get; set; }

        public int billProcedureDetailId { get; set; }

        public int billProcedureId { get; set; }

        public int procedureId { get; set; }

        public int doctorId { get; set; }

        public int? voucherId { get; set; }

        public double actualAmount { get; set; }

        public double returnedAmount { get; set; }

        public double balanceAmount { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string reason { get; set; }

        public int createdBy { get; set; }

        public DateTime createDate { get; set; }

        public virtual BillProcedureDetail BillProcedureDetail { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual User User { get; set; }
    }
}
