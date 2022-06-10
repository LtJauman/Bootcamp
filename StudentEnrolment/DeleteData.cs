using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentEnrolment
{
    public class DeleteData
    {
        public static void DeleteStudentById()
        {
            Console.WriteLine("Which student do you wish to delete? \n");
            DisplayData.DisplayStudents();
            Console.WriteLine("Enter the id of the student: ");
            var input = Console.ReadLine();
            int studentId = Int32.Parse(input);
            DeleteStudent(studentId);
        }
        private static void DeleteStudent(int studentId)
        {

            var context = new StudentEnrolmentContext();
            var studentToDelete = context.Student.FirstOrDefault(c => c.StudentId == studentId);
            context.Student.Remove(studentToDelete);
            context.SaveChanges();

        }
        public static void DeleteCourseById()
        {
            Console.WriteLine("Which course do you wish to delete? \n");
            DisplayData.DisplayCourses();
            Console.WriteLine("Enter the id of the course: ");
            var input = Console.ReadLine();
            int courseId = Int32.Parse(input);
            DeleteCourse(courseId);
        }
        private static void DeleteCourse(int courseId)
        {

            var context = new StudentEnrolmentContext();
            var courseToDelete = context.Course.FirstOrDefault(c => c.CourseId == courseId);
            context.Course.Remove(courseToDelete);
            context.SaveChanges();

        }
        public static void DeleteSubjectById()
        {
            Console.WriteLine("Which subject do you wish to delete? \n");
            DisplayData.DisplaySubjects();
            Console.WriteLine("Enter the id of the subject: ");
            var input = Console.ReadLine();
            int subjectId = Int32.Parse(input);
            DeleteSubject(subjectId);
        }
        private static void DeleteSubject(int subjectId)
        {
            var context = new StudentEnrolmentContext();
            var courseToDelete = context.Subject.FirstOrDefault(c => c.SubjectId == subjectId);
            context.Subject.Remove(courseToDelete);
            context.SaveChanges();
        }
    }
}
