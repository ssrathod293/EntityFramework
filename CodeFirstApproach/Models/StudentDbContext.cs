using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CodeFirstApproach.Models
{
   public class StudentDbContext:DbContext
    {
        public StudentDbContext()
        {

            Database.SetInitializer<StudentDbContext>
                (new CreateDatabaseIfNotExists<StudentDbContext>());
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Trainer> trainers { get; set; }

    }
}
