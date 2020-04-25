namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BillDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillDetail()
        {
            ServiceReturns = new HashSet<ServiceReturn>();
        }

        public int id { get; set; }

        public int billId { get; set; }

        public int serviceId { get; set; }

        public int? doctorId { get; set; }

        public double amount { get; set; }

        [StringLength(50)]
        public string discount { get; set; }

        public double? discountRate { get; set; }

        public bool isReturnFiled { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Service Service { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceReturn> ServiceReturns { get; set; }
    }
}
