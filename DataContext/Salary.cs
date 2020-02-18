namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Salary")]
    public partial class Salary
    {
        public int id { get; set; }

        public int employeeId { get; set; }

        public int? basic { get; set; }

        public int? housing { get; set; }

        public int? medical { get; set; }

        public int? TADA { get; set; }

        public int? other { get; set; }

        public int? total { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
