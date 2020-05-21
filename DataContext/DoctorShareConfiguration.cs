namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoctorShareConfiguration")]
    public partial class DoctorShareConfiguration
    {
        public int id { get; set; }

        public int doctorId { get; set; }

        public int? serviceId { get; set; }

        public int? procedureId { get; set; }

        public int percentage { get; set; }

        public DateTime createDate { get; set; }

        public int createdBy { get; set; }

        public DateTime? modifyDate { get; set; }

        public int? modifiedBy { get; set; }

        public virtual Procedure Procedure { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Service Service { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
