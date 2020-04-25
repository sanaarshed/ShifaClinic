namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Investor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Investor()
        {
            InvestorShareConfigurations = new HashSet<InvestorShareConfiguration>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string fullName { get; set; }

        [Required]
        [StringLength(100)]
        public string mobileNumber { get; set; }

        [StringLength(100)]
        public string phoneNumber { get; set; }

        [StringLength(100)]
        public string alternateMobileNumber { get; set; }

        [Required]
        [StringLength(500)]
        public string primaryAddress { get; set; }

        [StringLength(500)]
        public string secondaryAddress { get; set; }

        [Column(TypeName = "image")]
        public byte[] picture { get; set; }

        [Column(TypeName = "text")]
        public string notes { get; set; }

        public DateTime createDate { get; set; }

        public int createdBy { get; set; }

        public DateTime? modifyDate { get; set; }

        public int? modifiedBy { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestorShareConfiguration> InvestorShareConfigurations { get; set; }
    }
}
