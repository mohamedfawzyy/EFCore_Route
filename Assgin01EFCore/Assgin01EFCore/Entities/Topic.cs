﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgin01EFCore.Entities
{
    internal class Topic
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        //(contain) relation between course and topic

        public ICollection<Course> Courses { get; set; } = new HashSet<Course>(); //navigational property
    }
}
