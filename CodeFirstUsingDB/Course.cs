using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstUsingDB
{
    public class Course
    {
        [Required]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Duration { get; set; }

        [ForeignKey("Trainer")]
        public int trainerId { get; set; }
        public Trainer trainer { get; set; }
    }
}
