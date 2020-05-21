namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DoctorBookClosingDetail
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int drBookClosingId { get; set; }

        public int? serviceId { get; set; }

        public double? totalPrice { get; set; }

        public int? visits { get; set; }

        public double? sharePercentage { get; set; }

        public int? procedureId { get; set; }
        public virtual Service Service { get; set; }

    }
}
