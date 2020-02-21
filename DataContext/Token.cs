namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Token
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? billId { get; set; }

        public int? tokenNumber { get; set; }

        public DateTime? tokenDate { get; set; }

        public int? docId { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
