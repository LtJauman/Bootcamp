using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrolment
{
    public class Students
    {
            public string StudentId { get; set;  } 
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Students(string StudentId, string FirstName, string LastName)
        {
            this.StudentId = StudentId;
            this.FirstName = FirstName;
            this.LastName = LastName;

        }
    }
}
