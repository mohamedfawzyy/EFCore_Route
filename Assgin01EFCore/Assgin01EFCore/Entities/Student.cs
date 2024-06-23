using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgin01EFCore.Entities
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Fname { get; set; }
        [MaxLength(50)]
        public string Lname { get; set; }
        public string? Address { get; set; }
        [Range(5,20)]
        public int Age { get; set; }
        
        [ForeignKey(nameof(Student.Department))]
        public int DeptId { get; set; }   //this is our FK.

        [InverseProperty(nameof(Entities.Department.Students))]
        public Department Department { get; set; }  //navigational property one

        //relation betwwen student and studentCourse one to many

        [InverseProperty(nameof(StudentCourse.Student))]
        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>(); //navigational property
    } 
}
