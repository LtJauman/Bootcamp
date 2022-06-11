using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace StudentEnrolmentWebApp.Models
{
    public class StudentEnrolmentContext : DbContext
    {
        public DbSet<Students> Student { get; set; }

        public DbSet<Courses> Course { get; set; }

        public DbSet<Subjects> Subject { get; set; }
        public DbSet<CourseMembership> CourseMemberships { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=studentenrolment3;user=root;password=BigotesEsLAPUTAAma£$123");
        }

        public StudentEnrolmentContext(DbContextOptions<StudentEnrolmentContext> options)
            : base(options)
        {
        }

        public StudentEnrolmentContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.HasKey(e => e.StudentId);
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.Property(e => e.CourseName).IsRequired();
                entity.Property(e => e.CourseDescription).IsRequired();
                entity.HasKey(e => e.CourseId);

            });

            modelBuilder.Entity<Subjects>(entity =>
            {

                entity.Property(e => e.SubjectName).IsRequired();
                entity.Property(e => e.SubjectDescription).IsRequired();
                entity.HasKey(e => e.SubjectId);
                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Subjects);
            });

            modelBuilder.Entity<CourseMembership>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<CourseMembership>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.CourseMemberships)
                .HasForeignKey(sc => sc.StudentId);


            modelBuilder.Entity<CourseMembership>()
                .HasOne(sc => sc.Course)
                .WithMany(s => s.CourseMemberships)
                .HasForeignKey(sc => sc.CourseId);
        }

    }
}
