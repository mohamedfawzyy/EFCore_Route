using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgin01EFCore.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Fname { get; set; }
        [MaxLength(50)]
        public string Lname { get; set; }
        public string Address { get; set; }
        [Range(5,20)]
        public int Age { get; set; }
    }
}
