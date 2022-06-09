using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentEnrolment
{
    public class CourseList
    {
        private static readonly List<Courses> _courses = new();

        public void AddNewCourse() 
        {
            Console.WriteLine("Enter the course id: ");
            var input = Console.ReadLine();
            int id= Convert.ToInt32(input);
            Console.WriteLine("Enter the name of the new course: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter a description for the course: ");
            var description = Console.ReadLine();
            _courses.Add(new Courses(id, name, description));
        }
        public void DeleteItem()
        {
            this.DisplayItems();
            Console.WriteLine("Choose the id of the course to be deleted");
            var input = Console.ReadLine();
            int converted = Convert.ToInt32(input);
            var index = this.FindCourseIndex(converted);
            _courses.RemoveAt(index);

        }
        public int FindCourseIndex(int id)
        {
            var i = 0;
            foreach (var course in _courses)
            {
                if (course.CourseId == id)
                {
                    return i;
                }
                i++;
            }
            return -1;
        } // Can probably be improved
        public Courses ReturnCourse(int index)
        {
            var value = _courses.ElementAt(index);
            return value;
            
        }

        public void DisplayItems()
        {
            foreach (var course in _courses)
            {
                Console.WriteLine("Course Id {0}:{1} {2}", course.CourseId, course.CourseName, course.CourseDescription);
                
            }
        }
        public void ClearList()
        {
            _courses.Clear();
        }
        public void Populate() //Method to artificially add data, can be improve in further iterations of this program and have it grab data from a database
        {
            _courses.Add(new Courses(1, "Computer Science", "Learn how to code and build databases easily"));
            _courses.Add(new Courses(2, "Maths", "Learn how to differentiate, integrate and more!"));
            _courses.Add(new Courses(3, "Economics", "Understand how our economy works, what inflation is and much more"));
        }
    }
}
