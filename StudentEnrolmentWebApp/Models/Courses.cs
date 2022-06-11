using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrolmentWebApp.Models
{
    public class Courses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { set; get; }
        public string CourseName { set; get; }
        public string CourseDescription { set; get; }
        public ICollection<Subjects> Subjects { get; set; }
        public IList<CourseMembership> CourseMemberships { get; set; }

        public Courses(string CourseName, string CourseDescription)
        {
            this.CourseName = CourseName;
            this.CourseDescription = CourseDescription;

        }
    }
}
