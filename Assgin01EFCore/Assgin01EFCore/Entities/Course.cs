using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assgin01EFCore.Entities
{
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Duration { get; set; }
        [StringLength(50,MinimumLength =3)]
        public string Name { get; set; }
        public string Description { get; set; }

        //(contain)relation between course  and topic many to one
        [ForeignKey(nameof(Course.Topic))]
        public int TopicId { get; set; }
        public Topic Topic { get; set; } //navigationl property

        //realtion between course and studentcourse one to many

        [InverseProperty(nameof(StudentCourse.Course))]
        public ICollection<StudentCourse> StudentCourses { get; set; }= new HashSet<StudentCourse>();

        //relation between course and courseInstructor
        [InverseProperty(nameof(CourseInstructor.Course))]
        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new HashSet<CourseInstructor>();
    }
}
