namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvestorShareConfiguration")]
    public partial class InvestorShareConfiguration
    {
        public int id { get; set; }

        public int investorId { get; set; }

        public int serviceId { get; set; }

        public int percentage { get; set; }

        public DateTime createDate { get; set; }

        public int createdBy { get; set; }

        public DateTime? modifyDate { get; set; }

        public int? modifiedBy { get; set; }

        public virtual Investor Investor { get; set; }

        public virtual Service Service { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
