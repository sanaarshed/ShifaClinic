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
        }

        public int id { get; set; }

        public int? departmentId { get; set; }

        public int? fees { get; set; }

        public int? sharePercentage { get; set; }

        [StringLength(50)]
        public string backupPhone { get; set; }

        [StringLength(100)]
        public string licenseNumber { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public DateTime? dob { get; set; }

        [StringLength(20)]
        public string gender { get; set; }

        [StringLength(50)]
        public string mobileNumber { get; set; }

        [StringLength(1000)]
        public string permanentAddress { get; set; }

        [MaxLength(200)]
        public byte[] photo { get; set; }

        [StringLength(50)]
        public string CNIC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }

        public virtual DoctorDepartment DoctorDepartment { get; set; }
    }
}
