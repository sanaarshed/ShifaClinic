namespace ShifaClinic.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Medicine
    {
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string title { get; set; }

        public double price { get; set; }

        public int stripPerPack { get; set; }

        [Required]
        [StringLength(200)]
        public string mType { get; set; }

        [Required]
        [StringLength(200)]
        public string mContent { get; set; }

        [Required]
        [StringLength(200)]
        public string alsoKnownAs { get; set; }

        [Required]
        [StringLength(200)]
        public string brandName { get; set; }

        public long dawaiId { get; set; }
    }
}
