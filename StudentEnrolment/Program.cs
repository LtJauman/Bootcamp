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
            using var context = new StudentEnrolmentContext();
            context.Database.EnsureCreated();
            bool active = true;
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
                active = InputSwitcher(input);
            }
        }
        private static bool InputSwitcher(string input)
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
                        DisplayData.DisplayStudents();
                    }
                    if (displayInput == "2")
                    {
                        DisplayData.DisplayCourses();
                    }
                    if (displayInput == "3")
                    {
                        DisplayData.DisplaySubjects();
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

                        InsertData.InputStudentInfo();

                    }
                    if (addInput == "2")
                    {
                        InsertData.InputCourseInfo();

                    }
                    if (addInput == "3")
                    {
                        InsertData.InputSubjectInfo();

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
                        DeleteData.DeleteStudentById();
                    }
                    if (deleteInput == "2")
                    {
                        DeleteData.DeleteCourseById();
                    }
                    if (deleteInput == "3")
                    {
                        DeleteData.DeleteSubjectById();
                    }
                    return true;
                case "4":
                    Console.WriteLine("Exiting...");
                    return false;
                default:
                    return true;

            }

        }

    }
}

