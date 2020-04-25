namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            BillDetails = new HashSet<BillDetail>();
            BillProcedureDetails = new HashSet<BillProcedureDetail>();
            DoctorBookClosings = new HashSet<DoctorBookClosing>();
            DoctorShareConfigurations = new HashSet<DoctorShareConfiguration>();
            DoctorShareConfigurationHistories = new HashSet<DoctorShareConfigurationHistory>();
            ProcedureReturns = new HashSet<ProcedureReturn>();
            ServiceReturns = new HashSet<ServiceReturn>();
            Tokens = new HashSet<Token>();
        }

        public int id { get; set; }

        public int departmentId { get; set; }

        public bool isConsultant { get; set; }

        public bool isOpd { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public DateTime? dob { get; set; }

        public int? age { get; set; }

        public bool? gender { get; set; }

        [StringLength(16)]
        public string CNIC { get; set; }

        [StringLength(50)]
        public string mobileNumber { get; set; }

        [StringLength(50)]
        public string backupPhone { get; set; }

        [StringLength(1000)]
        public string permanentAddress { get; set; }

        [Column(TypeName = "text")]
        public string credentials { get; set; }

        [StringLength(1000)]
        public string licenseNumber { get; set; }

        public double consultantFee { get; set; }

        public double opdFee { get; set; }

        [Column(TypeName = "image")]
        public byte[] photo { get; set; }

        public int createdBy { get; set; }

        public DateTime createdDate { get; set; }

        public int? modifiedBy { get; set; }

        public DateTime? modifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillProcedureDetail> BillProcedureDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorBookClosing> DoctorBookClosings { get; set; }

        public virtual DoctorDepartment DoctorDepartment { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorShareConfiguration> DoctorShareConfigurations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorShareConfigurationHistory> DoctorShareConfigurationHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcedureReturn> ProcedureReturns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceReturn> ServiceReturns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Token> Tokens { get; set; }
    }
}
