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
        //public static void GetCourseName()
        //{
        //    Console.WriteLine("Which course do you wish to delete? Note: this will also delete the subjects which this course contains");
        //    DisplayData.DisplayCourses();
        //    Console.WriteLine(" ");
        //    Console.WriteLine("Enter the name of the course: ");
        //    string courseName = Console.ReadLine();
        //    _ = DeleteCourseAsync(courseName);
        //}
        //private static async Task DeleteCourseAsync(string courseName)
        //{

        //    using (var context = new StudentEnrolmentContext())
        //    {
        //        var courseToDelete = await context.Course.FirstOrDefaultAsync(c => c.CourseName == courseName);
        //        var subjects = context.Subject.Include(p => p.Course);
        //        foreach (var subject in subjects)
        //        {
        //            if (subject.CourseId == courseToDelete.CourseId)
        //            {
        //                context.Subject.Remove(subject);
        //            }
        //        }
        //        context.Course.Remove(courseToDelete);
        //        context.SaveChanges();
        //    }
        //}
        //public static void GetSubjectName()
        //{
        //    Console.WriteLine("Which subject do you wish to delete?");
        //    Console.WriteLine(" ");
        //    DisplayData.DisplaySubjects();
        //    Console.WriteLine(" ");
        //    Console.WriteLine("Enter the name of the subject: ");
        //    string subjectName = Console.ReadLine();
        //    _ = DeleteSubjectAsync(subjectName);
        //}
        //private static async Task DeleteSubjectAsync(string subjectName)
        //{

        //    using (var context = new StudentEnrolmentContext())
        //    {
        //        var subjectToDelete = await context.Subject.FirstOrDefaultAsync(c => c.SubjectName == subjectName);
        //        context.Subject.Remove(subjectToDelete);
        //        context.SaveChanges();
        //    }
        //}
        public static void DeleteStudentById()
        {
            Console.WriteLine("Which student do you wish to delete?");
            Console.WriteLine(" ");
            DisplayData.DisplayStudents();
            Console.WriteLine(" ");
            Console.WriteLine("Enter the id of the student: ");
            var input = Console.ReadLine();
            int studentId = Int32.Parse(input);
            _ = DeleteStudentAsync(studentId);
        }
        private static async Task DeleteStudentAsync(int studentId)
        {

            var context = new StudentEnrolmentContext();
            var studentToDelete = await context.Student.FirstOrDefaultAsync(c => c.StudentId == studentId);
            context.Student.Remove(studentToDelete);
            context.SaveChanges();

        }
        public static void DeleteCourseById()
        {
            Console.WriteLine("Which course do you wish to delete?");
            Console.WriteLine(" ");
            DisplayData.DisplayCourses();
            Console.WriteLine(" ");
            Console.WriteLine("Enter the id of the course: ");
            var input = Console.ReadLine();
            int courseId = Int32.Parse(input);
            _ = DeleteCourseAsync(courseId);
        }
        private static async Task DeleteCourseAsync(int courseId)
        {

            var context = new StudentEnrolmentContext();
            var courseToDelete = await context.Course.FirstOrDefaultAsync(c => c.CourseId == courseId);
            context.Course.Remove(courseToDelete);
            context.SaveChanges();

        }
        public static void DeleteSubjectById()
        {
            Console.WriteLine("Which subject do you wish to delete?");
            Console.WriteLine(" ");
            DisplayData.DisplaySubjects();
            Console.WriteLine(" ");
            Console.WriteLine("Enter the id of the subject: ");
            var input = Console.ReadLine();
            int subjectId = Int32.Parse(input);
            _ = DeleteSubjectAsync(subjectId);
        }
        private static async Task DeleteSubjectAsync(int subjectId)
        {

            var context = new StudentEnrolmentContext();
            var courseToDelete = await context.Subject.FirstOrDefaultAsync(c => c.SubjectId == subjectId);
            context.Subject.Remove(courseToDelete);
            context.SaveChanges();

        }
    }
}
