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
     
        public string Name { get; set; }

        public int Bouns { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Sallary { get; set; }
        [Required]
        public string Address { get; set; }

        public double  HourRate { get; set; }
    }
}
