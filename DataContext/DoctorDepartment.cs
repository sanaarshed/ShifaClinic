namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DoctorDepartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoctorDepartment()
        {
            Doctors = new HashSet<Doctor>();
        }

        public int id { get; set; }

        [StringLength(200)]
        public string title { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        public int? createdBy { get; set; }

        public int? modifiedBy { get; set; }

        public DateTime? createDate { get; set; }

        public DateTime? modifyDate { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
