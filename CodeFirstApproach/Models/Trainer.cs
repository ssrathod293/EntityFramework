using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public int Experience { get; set; }
        public ICollection<Student> students { get; set; }

    }
}
