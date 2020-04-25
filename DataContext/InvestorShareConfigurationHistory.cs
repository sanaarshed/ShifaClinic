namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvestorShareConfigurationHistory")]
    public partial class InvestorShareConfigurationHistory
    {
        public int id { get; set; }

        public int investorId { get; set; }

        public int serviceId { get; set; }

        public int percentage { get; set; }

        public DateTime shareFrom { get; set; }

        public DateTime shareTo { get; set; }

        public DateTime createDate { get; set; }

        public int createdBy { get; set; }

        public virtual Service Service { get; set; }

        public virtual User User { get; set; }
    }
}
