namespace CodeFirstUsingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblStudent")]
    public partial class tblStudent
    {
        [Key]
        public int RollNumber { get; set; }

        [StringLength(8000)]
        public string StudentName { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        public float Fees { get; set; }

        [StringLength(14)]
        public string Mobile { get; set; }

        public int? TrainerId { get; set; }

        public virtual Trainer Trainer { get; set; }
    }
}
