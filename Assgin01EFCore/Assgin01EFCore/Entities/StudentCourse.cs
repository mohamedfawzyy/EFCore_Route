using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgin01EFCore.Entities
{
    internal class StudentCourse
    {
        [ForeignKey(nameof(StudentCourse.Student))]
        public int StudId { get; set; }
        [ForeignKey(nameof(StudentCourse.Course))]
        public int CourseId { get; set; }
        public string Grade { get; set; }

        [InverseProperty(nameof(Entities.Student.StudentCourses))]
        public Student Student { get; set; } //navigational property

        [InverseProperty(nameof(Entities.Course.StudentCourses))]
        public Course Course { get; set; }  //navigational property
    }
}
