using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrolment
{
    public class Courses
    {
        public string CourseId { set; get; }
        public string CourseName { set; get; }
        public string CourseDescription { set; get; }

        public Courses(string CourseId, string CourseName, string CourseDescription)
        {
            this.CourseId = CourseId;
            this.CourseName = CourseName;
            this.CourseDescription = CourseDescription;

        }
    }
}
