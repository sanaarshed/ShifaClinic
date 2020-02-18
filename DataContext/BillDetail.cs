namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BillDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int billId { get; set; }

        public int? serviceId { get; set; }

        public int? doctorId { get; set; }

        public int amount { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Service Service { get; set; }
    }
}
