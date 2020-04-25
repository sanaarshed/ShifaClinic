namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            BillDetails = new HashSet<BillDetail>();
            DoctorShareConfigurations = new HashSet<DoctorShareConfiguration>();
            DoctorShareConfigurationHistories = new HashSet<DoctorShareConfigurationHistory>();
            InvestorShareConfigurations = new HashSet<InvestorShareConfiguration>();
            InvestorShareConfigurationHistories = new HashSet<InvestorShareConfigurationHistory>();
            ServiceReturns = new HashSet<ServiceReturn>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string title { get; set; }

        [StringLength(1000)]
        public string description { get; set; }

        public int? price { get; set; }

        public int? createdBy { get; set; }

        public int? modifiedBy { get; set; }

        public DateTime? createDate { get; set; }

        public DateTime? modifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorShareConfiguration> DoctorShareConfigurations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorShareConfigurationHistory> DoctorShareConfigurationHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestorShareConfiguration> InvestorShareConfigurations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestorShareConfigurationHistory> InvestorShareConfigurationHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceReturn> ServiceReturns { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
