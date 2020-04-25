namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ServiceReturn
    {
        public int id { get; set; }

        public int billId { get; set; }

        public int billDetailId { get; set; }

        public int serviceId { get; set; }

        public int? doctorId { get; set; }

        public int patientId { get; set; }

        public int voucherId { get; set; }

        public double actualAmount { get; set; }

        public double returnedAmount { get; set; }

        public double? balanceAmount { get; set; }

        [Column(TypeName = "text")]
        public string reason { get; set; }

        public DateTime createDate { get; set; }

        public int createdBy { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual BillDetail BillDetail { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Service Service { get; set; }

        public virtual User User { get; set; }
    }
}
