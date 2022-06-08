using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrolment
{
    class SubjectList
    {
        private static readonly List<Subjects> _subjects = new();
        public void AddNewSubject()
        {
            Console.WriteLine("Enter the course id: ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter a new name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a description: ");
            string description = Console.ReadLine();
            _subjects.Add(new Subjects(id, name, description));
        }
        public void DeleteItem()
        {
            this.DisplayItems();
            Console.WriteLine("Choose the id of the course to be deleted");
            string input = Console.ReadLine();
            var index = this.FindSubjectIndex(input);
            _subjects.RemoveAt(index);

        }
        public int FindSubjectIndex(string id)
        {
            var i = 0;
            foreach (var subject in _subjects)
            {
                if (subject.SubjectId == id)
                    return i;
                else i++;
            }
            return -1;
        }
        public Subjects ReturnSubjects(int index)
        {
            var value = _subjects.ElementAt(index);
            return value;

        }
        public void DisplayItems()
        {
            foreach (var subject in _subjects)
            {
                Console.WriteLine("Subject Id {0}:{1} {2}", subject.SubjectId, subject.SubjectName, subject.SubjectDescription);
                Console.ReadLine();
            }
        }
        public void ClearList()
        {
            _subjects.Clear();
        }
        public void Populate() //Method to artificially add data, can be improve in further iterations of this program and have it grab data from a database
        {
            _subjects.Add(new Subjects("1", "Differentiation", "Learn about differentiation"));
            _subjects.Add(new Subjects("2", "Integration", "Learn about integration"));
            _subjects.Add(new Subjects("3", "Microeconomics", "Learn about Microeconomics"));
            _subjects.Add(new Subjects("4", "Macroeconomics", "Learn about macroeconomics"));
            _subjects.Add(new Subjects("5", "MySQL", "Learn about databases and SQL"));

        }
    }
}
