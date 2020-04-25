namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Voucher
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string title { get; set; }

        public int? referenceKey { get; set; }

        [Required]
        [StringLength(100)]
        public string referenceEntity { get; set; }

        [Column(TypeName = "text")]
        public string referenceData { get; set; }

        public double amount { get; set; }

        [Required]
        [StringLength(10)]
        public string mode { get; set; }

        [Required]
        [StringLength(3)]
        public string flow { get; set; }

        public DateTime createDate { get; set; }

        public int createdBy { get; set; }

        public virtual User User { get; set; }
    }
}
