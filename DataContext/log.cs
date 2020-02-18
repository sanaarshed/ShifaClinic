namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("log")]
    public partial class log
    {
        public int id { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        [StringLength(100)]
        public string tableName { get; set; }

        [StringLength(100)]
        public string columnName { get; set; }

        [StringLength(100)]
        public string action { get; set; }

        [Column(TypeName = "text")]
        public string previousValue { get; set; }

        public int? createdBy { get; set; }

        public DateTime? createDate { get; set; }

        public virtual User User { get; set; }
    }
}
