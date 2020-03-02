namespace ShifaClinic.DataContext.temp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doctor
    {
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

        public int? age { get; set; }

        public bool? gender { get; set; }

        [StringLength(50)]
        public string mobileNumber { get; set; }

        [StringLength(1000)]
        public string permanentAddress { get; set; }

        [MaxLength(200)]
        public byte[] photo { get; set; }

        [StringLength(50)]
        public string CNIC { get; set; }

        public int createdBy { get; set; }

        public DateTime createdDate { get; set; }

        public int? midifiedBy { get; set; }

        public DateTime? modifiedDate { get; set; }
    }
}
