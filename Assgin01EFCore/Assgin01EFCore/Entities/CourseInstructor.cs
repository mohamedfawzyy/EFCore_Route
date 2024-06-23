using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgin01EFCore.Entities
{
    internal class CourseInstructor
    {
        [ForeignKey(nameof(CourseInstructor.Instructor))]
        public int InstId { get; set; }
        [ForeignKey(nameof(CourseInstructor.Course))]
        public int CourseId { get; set; }
        [Required]
        public string Evaluate { get; set; }

        [InverseProperty(nameof(Entities.Instructor.CourseInstructors))]
        public Instructor Instructor { get; set; } //navigational property
        [InverseProperty(nameof(Entities.Course.CourseInstructors))]
        public Course Course { get; set; }  //navigational property
    }
}
