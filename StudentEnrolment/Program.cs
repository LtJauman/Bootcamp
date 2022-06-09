using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace StudentEnrolment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            var studentList = new StudentList();
            var courseList = new CourseList();
            var subjectList = new SubjectList();
            studentList.Populate();
            courseList.Populate();
            subjectList.Populate();
            while (active == true)
            {
                Console.WriteLine("Welcome to StudentEnrollment app");
                Console.WriteLine("What do you wish to do? (enter a number)");
                Console.WriteLine("1- Display data");
                Console.WriteLine("2- Add new data");
                Console.WriteLine("3- Delete data");
                Console.WriteLine("4- Exit");
                Console.WriteLine("Enter answer: ");

                string input = Console.ReadLine();
                active = InputSwitcher(studentList, courseList, subjectList, input);



            }
        }
        private static bool InputSwitcher(StudentList studentList, CourseList courseList, SubjectList subjectList, string input)
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine("What do you wish to do? (Enter a number)");
                    Console.WriteLine("1. Display students");
                    Console.WriteLine("2. Display courses");
                    Console.WriteLine("3. Display subjects");
                    string displayInput = Console.ReadLine();
                    if (displayInput == "1")
                    {
                        studentList.DisplayItems();
                    }
                    if (displayInput == "2")
                    {
                        courseList.DisplayItems();
                    }
                    if (displayInput == "3")
                    {
                        subjectList.DisplayItems();
                    }
                    return true;
                case "2":
                    Console.WriteLine("What do you wish to do? (Enter a number)");
                    Console.WriteLine("1. Add a new student");
                    Console.WriteLine("2. Add a new course");
                    Console.WriteLine("3. Add a new subject");
                    string addInput = Console.ReadLine();

                    if (addInput == "1")
                    {

                        studentList.AddNewStudent();

                    }
                    if (addInput == "2")
                    {
                        courseList.AddNewCourse();

                    }
                    if (addInput == "3")
                    {
                        subjectList.AddNewSubject();

                    }
                    return true;
                case "3":
                    Console.WriteLine("What do you wish to do? (Enter a number)");
                    Console.WriteLine("1. Delete a student");
                    Console.WriteLine("2. Delete a course");
                    Console.WriteLine("3. Delete a  subject");
                    string deleteInput = Console.ReadLine();
                    if (deleteInput == "1")
                    {
                        studentList.DeleteItem();
                    }
                    if (deleteInput == "2")
                    {
                        courseList.DeleteItem();
                    }
                    if (deleteInput == "3")
                    {
                        subjectList.DeleteItem();
                    }
                    return true;
                case "4":
                    Console.WriteLine("Exiting...");
                    return false;
                default:
                    return true;

            }

        }

        // So the task wants me to use the following to ensure the database is created (which I don't think it requires migration). To do this, I think it should run it at the start or when reading from a database such as doing list functions
        //using var context = new StudentEnrolmentContext();
        //context.Database.EnsureCreated();
    }
}

