namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashIn")]
    public partial class CashIn
    {
        public int id { get; set; }

        public double totalCashIn { get; set; }

        [StringLength(50)]
        public string remarks { get; set; }

        public DateTime createDate { get; set; }

        public int createdBy { get; set; }

        public DateTime? modifyDate { get; set; }

        public int? modifiedBy { get; set; }

        public int? Rs5000 { get; set; }

        public int? Rs1000 { get; set; }

        public int? Rs500 { get; set; }

        public int? Rs100 { get; set; }

        public int? Rs50 { get; set; }

        public int? Rs20 { get; set; }

        public int? Rs10 { get; set; }

        public int? Rs5 { get; set; }

        public int? Rs2 { get; set; }

        public int? Rs1 { get; set; }
    }
}
