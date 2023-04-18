using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    //public class Student
    //{
    //    public int studentId { get; set; }
    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //}
    //    [Table("tblStudent")]
    //    public class Student
    //    {
    //        internal int rol;

    //        [Key]
    //        public int RollNumber { get; set; }
    //        [Column("StudentName")]
    //        public string Name { get; set; }
    //        public string Gender { get; set; }
    //    }

    //[Table("tblStudent")]
    //public class Student
    //{


    //    [Key]
    //    public int RollNumber { get; set; }

    //    [Column("StudentName",TypeName ="varchar")]
    //    public string Name { get; set; }

    //    [Column(TypeName ="varchar")]
    //    [StringLength(10)]
    //    public string Gender { get; set; }

    //    [Required]
    //    [StringLength(200)]
    //    public string Email { get; set; }

    //    [NotMapped]
    //    public string confirmEmail { get; set; }

    //}
    [Table("tblStudent")]
    public class Student
    {


        [Key]
        public int RollNumber { get; set; }

        [Column("StudentName", TypeName = "varchar")]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [NotMapped]
        public string confirmEmail { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [Index("Ix_Student_Fees",IsClustered =false,IsUnique =false)]
        public float Fees { get; set; }

        [MaxLength(14)]
        public string Mobile { get; set; }

        [ForeignKey("Trainer")]
        public int? TrainerId { get; set; }
        public Trainer Trainer { get; set; }


    }
}

