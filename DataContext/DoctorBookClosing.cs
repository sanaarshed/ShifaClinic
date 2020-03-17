namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoctorBookClosing")]
    public partial class DoctorBookClosing
    {
        public int id { get; set; }

        public int? docId { get; set; }

        public int? total { get; set; }

        public int? balance { get; set; }

        public int? paidAmmount { get; set; }

        public DateTime createdDate { get; set; }

        public int createdBy { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
