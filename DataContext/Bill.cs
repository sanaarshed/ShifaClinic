namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            BillDetails = new HashSet<BillDetail>();
            Tokens = new HashSet<Token>();
        }

        public int id { get; set; }

        public int patientId { get; set; }

        public int? gross { get; set; }

        public int? discount { get; set; }

        public int? billAmount { get; set; }

        public int? paid { get; set; }

        public int? balance { get; set; }

        public int createdBy { get; set; }

        public DateTime createDate { get; set; }

        public int? modifiedBy { get; set; }

        public DateTime? modifyDate { get; set; }

        [StringLength(1000)]
        public string remarks { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Token> Tokens { get; set; }
    }
}
