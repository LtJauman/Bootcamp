
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrolment
{
    public class Subjects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { set; get; }
        public string SubjectName { set; get; }
        public string SubjectDescription { set; get; }
        // Shows that it belongs to a course, should I also add the course id on constructor? 
        public Courses Course { get; set; }
        public Subjects(string SubjectName, string SubjectDescription)
        {
            this.SubjectName = SubjectName;
            this.SubjectDescription = SubjectDescription;

        }
    }
}
