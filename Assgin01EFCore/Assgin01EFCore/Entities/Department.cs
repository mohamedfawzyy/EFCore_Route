using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgin01EFCore.Entities
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime HiringDate { get; set; }

        //(Enroll) relation between student and dept one to many
        [InverseProperty(nameof(Student.Department))]
        public ICollection<Student> Students { get; set; } = new HashSet<Student>(); //navigational preoperty many relation enroll

        //(work) relation between instructor and dept one to many 
        [InverseProperty(nameof(Instructor.Department))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>(); //navigational property many of instructors works


        //(control) relation between instructor one to one
        [ForeignKey(nameof(Department.Instructor_Manager))]
        public int? InstId { get; set; } //Fk of Instructor_ID
        public Instructor? Instructor_Manager { get; set; }

    }
}
