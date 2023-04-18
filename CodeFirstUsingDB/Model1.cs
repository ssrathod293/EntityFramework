using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstUsingDB
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=StudentDBcontext")
        {
        }

        public virtual DbSet<tblStudent> tblStudents { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblStudent>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<tblStudent>()
                .Property(e => e.Gender)
                .IsUnicode(false);
        }
    }
}
