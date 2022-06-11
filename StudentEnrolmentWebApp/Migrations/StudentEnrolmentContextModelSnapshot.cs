﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentEnrolmentWebApp.Models;

namespace StudentEnrolmentWebApp.Migrations
{
    [DbContext(typeof(StudentEnrolmentContext))]
    partial class StudentEnrolmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("StudentEnrolmentWebApp.Models.CourseMembership", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseMemberships");
                });

            modelBuilder.Entity("StudentEnrolmentWebApp.Models.Courses", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("StudentEnrolmentWebApp.Models.Students", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentEnrolmentWebApp.Models.Subjects", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SubjectId");

                    b.HasIndex("CourseId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("StudentEnrolmentWebApp.Models.CourseMembership", b =>
                {
                    b.HasOne("StudentEnrolmentWebApp.Models.Courses", "Course")
                        .WithMany("CourseMemberships")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentEnrolmentWebApp.Models.Students", "Student")
                        .WithMany("CourseMemberships")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentEnrolmentWebApp.Models.Subjects", b =>
                {
                    b.HasOne("StudentEnrolmentWebApp.Models.Courses", "Course")
                        .WithMany("Subjects")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentEnrolmentWebApp.Models.Courses", b =>
                {
                    b.Navigation("CourseMemberships");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("StudentEnrolmentWebApp.Models.Students", b =>
                {
                    b.Navigation("CourseMemberships");
                });
#pragma warning restore 612, 618
        }
    }
}
