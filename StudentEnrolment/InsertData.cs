using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentEnrolment
{
    public class InsertData
    {
        public static void InputStudentInfo()
        {
            Console.WriteLine("Enter the student's name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's surname: ");
            string lastName = Console.ReadLine();
            InsertStudent(firstName, lastName);
        }
        private static void InsertStudent(string firstName, string lastName)
        {
            var context = new StudentEnrolmentContext();
            context.Student.Add(new Students(firstName, lastName));
            context.SaveChanges();
        }
        public static void InputCourseInfo()
        {
            Console.WriteLine("Enter the course's name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the course description: ");
            string courseDescription = Console.ReadLine();
            InsertCourse(courseName, courseDescription);
        }
        private static void InsertCourse(string courseName, string courseDescription)
        {
            var context = new StudentEnrolmentContext();
            context.Course.Add(new Courses(courseName, courseDescription));
            context.SaveChanges();
        }
        public static void InputSubjectInfo()
        {
            Console.WriteLine("Enter the subject's name: ");
            string subjectName = Console.ReadLine();
            Console.WriteLine("Enter the subject description: ");
            string subjectDescription = Console.ReadLine();
            InsertSubject(subjectName, subjectDescription);
        }
        private static void InsertSubject(string subjectName, string subjectDescription)
        {
            var context = new StudentEnrolmentContext();
            context.Subject.Add(new Subjects(subjectName, subjectDescription));
            context.SaveChanges();
        }
    }
}
