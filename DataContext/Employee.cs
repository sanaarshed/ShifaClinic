namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Salaries = new HashSet<Salary>();
        }

    
        public int id { get; set; }

        public int? designationId { get; set; }

        [StringLength(200)]
        public string fullName { get; set; }

        [StringLength(200)]
        public string fatherName { get; set; }

        [StringLength(5)]
        public string bloodGroup { get; set; }

        [StringLength(50)]
        public string contactNumber { get; set; }

        public DateTime? joinDate { get; set; }

        [Column(TypeName = "image")]
        public byte[] photograph { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dob { get; set; }

        [Column(TypeName = "text")]
        public string presentAddress { get; set; }

        [Column(TypeName = "text")]
        public string permanentAddress { get; set; }

        public bool? gender { get; set; }

        public int? createdBy { get; set; }

        public int? modifiedBy { get; set; }

        public DateTime? createDate { get; set; }

        public DateTime? modifyDate { get; set; }

        public virtual Designation Designation { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
