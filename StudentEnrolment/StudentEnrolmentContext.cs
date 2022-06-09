using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace StudentEnrolment
{
    class StudentEnrolmentContext : DbContext
    {
        public DbSet<Students> Student { get; set; }

        public DbSet<Courses> Course { get; set; }

        public DbSet<Subjects> Subject { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=studentenrolment;user=root;password=BigotesEsLAPUTAAma£$123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentId);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.CourseId);
                entity.Property(e => e.CourseName).IsRequired();
                entity.Property(e => e.CourseDescription).IsRequired();
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.HasKey(e => e.SubjectId);
                entity.Property(e => e.SubjectName).IsRequired();
                entity.Property(e => e.SubjectDescription).IsRequired();
            });
        }

    }
}
