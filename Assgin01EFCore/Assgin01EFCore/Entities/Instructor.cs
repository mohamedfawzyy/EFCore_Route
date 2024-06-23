using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgin01EFCore.Entities
{
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int? Bouns { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Sallary { get; set; }
        [Required]
        public string Address { get; set; }

        public double  HourRate { get; set; }


        //relation instrucor works in one Dept and Dept has more than one instrucor
        [ForeignKey(nameof(Instructor.Department))]
        public int DeptId { get; set; } //FK of DeptID in instructor Table.

        [InverseProperty(nameof(Entities.Department.Instructors))]
        public Department Department { get; set; } //navigational property of relation instructor work

        //relation between instructor and courseinstructor
        [InverseProperty(nameof(CourseInstructor.Instructor))]
        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new HashSet<CourseInstructor>(); //navigational propery




    }
}
