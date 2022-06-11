using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrolmentWebApp.Models
{
    public class CourseMembership
    {
        public int StudentId { get; set; }
        public Students Student { get; set; }
        public int CourseId { get; set; }
        public Courses Course { get; set; }
    }
}
