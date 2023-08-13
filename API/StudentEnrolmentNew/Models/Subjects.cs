
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrolmentNew.Models
{
    public class Subjects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { set; get; }
        public string SubjectName { set; get; }
        public string SubjectDescription { set; get; }
        // Shows that it belongs to a course, should I also add the course id on constructor? 
        public Courses? Course { get; set; }
        [ForeignKey("Course")]
        public int? CourseId { set; get; }
        public Subjects(string SubjectName, string SubjectDescription)
        {
            this.SubjectName = SubjectName;
            this.SubjectDescription = SubjectDescription;
        }
    }
}
