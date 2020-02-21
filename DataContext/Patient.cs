namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            Bills = new HashSet<Bill>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string fullName { get; set; }

        [StringLength(50)]
        public string mobileName { get; set; }

        public bool? gender { get; set; }

        public int? age { get; set; }

        [StringLength(50)]
        public string CNIC { get; set; }

        public double? weight { get; set; }

        public double? hight { get; set; }

        public double? bloodPressure { get; set; }

        [StringLength(50)]
        public string bloodGroup { get; set; }

        [StringLength(50)]
        public string fatherName { get; set; }

        [StringLength(50)]
        public string fatherMobile { get; set; }

        public int createdBy { get; set; }

        public int? modifiedBy { get; set; }

        public DateTime? createDate { get; set; }

        public DateTime? modifiedDate { get; set; }

        public int? token { get; set; }

        public int? doctorId { get; set; }

        [StringLength(20)]
        public string patientType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
