using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrolment
{
    public class Subjects
    {
        public string SubjectId { set; get; }
        public string SubjectName { set; get; }
        public string SubjectDescription { set; get; }
        public Courses Course { get; set; }
        public Subjects(string SubjectId, string SubjectName, string SubjectDescription)
        {
            this.SubjectId = SubjectId;
            this.SubjectName = SubjectName;
            this.SubjectDescription = SubjectDescription;

        }
    }
}
