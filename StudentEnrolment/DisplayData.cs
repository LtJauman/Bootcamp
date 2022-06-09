using System;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace StudentEnrolment
{
    public class DisplayData
    {
        public static void DisplaySubjects()
        {


            var context = new StudentEnrolmentContext();
            var subjects = context.Subject.Include(p => p.Course);
                foreach (var subject in subjects)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"Subject name: {subject.SubjectName}");
                    data.AppendLine($"Description: {subject.SubjectDescription}");
                    //data.AppendLine($"Course category: {subject.Course.CourseName}");
                    // Update of subject class is needed to link it to courses, leave it commented for now
                    Console.WriteLine(data.ToString());
                }

        }
        public static void DisplayCourses()
        {


            var context = new StudentEnrolmentContext();
            var courses = context.Course;
            foreach (var course in courses)
            {
                var data = new StringBuilder();
                data.AppendLine($"Course ID: {course.CourseId}");
                data.AppendLine($"Course name: {course.CourseName}");
                data.AppendLine($"Description: {course.CourseDescription}");
                Console.WriteLine(data.ToString());
            }

        }
        public static void DisplayStudents()
        {
            var context = new StudentEnrolmentContext();
            var students = context.Student;
            foreach (var student in students)
            {
                    var data = new StringBuilder();
                    data.AppendLine($"Student ID {student.StudentId}");
                    data.AppendLine($"Student name: {student.FirstName} {student.LastName}");
                    Console.WriteLine(data.ToString());
            }

        }

    }
}
