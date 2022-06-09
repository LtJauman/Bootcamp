using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentEnrolment
{
    public class StudentList
    {
        private static readonly List<Students> _students = new();

        public void AddNewStudent() 
        {
            Console.WriteLine("Enter the student id: ");
            var input = Console.ReadLine();
            int id = Convert.ToInt32(input);
            Console.WriteLine("Enter a new name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a new surname: ");
            string surname = Console.ReadLine();
            _students.Add(new Students(id, name, surname));
        }
        public void DeleteItem()
        {
            this.DisplayItems();
            Console.WriteLine("Choose the id of the student to be deleted");
            var input = Console.ReadLine();
            int index = Convert.ToInt32(input);
            _students.RemoveAt(index);

        }
        public int FindStudentIndex(int id)
        {
            var i = 0;
            foreach (var student in _students)
            {
                if (student.StudentId == id)
                 return i; 
                else i++;
            }
            return -1;
        }
        public Students ReturnStudent(int index)
        {
            var value = _students.ElementAt(index);
            return value;
            
        }

        public void DisplayItems()
        {
            foreach (var student in _students)
            {
                Console.WriteLine("Student Id {0}:{1} {2}", student.StudentId, student.FirstName, student.LastName);
                
            }
        }
        public void ClearList()
        {
            _students.Clear();
        }
        public void Populate() //Method to artificially add data, can be improve in further iterations of this program and have it grab data from a database
        {
            _students.Add(new Students(1, "Diego" ,"Jaumandreu"));
            _students.Add(new Students(2, "Zak", "Hersi"));
            _students.Add(new Students(3, "Mohammed", "Hussain"));
            _students.Add(new Students(4, "Joraver", "Rao"));
        }
    }
}
