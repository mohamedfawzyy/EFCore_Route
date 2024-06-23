using Assgin01EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgin01EFCore.Configurations
{
    internal class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(SC => new { SC.StudId, SC.CourseId });
            builder.HasOne(SC => SC.Student)
                .WithMany(S => S.StudentCourses)
                .HasForeignKey(SC=>SC.StudId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(SC => SC.Course)
             .WithMany(C=>C.StudentCourses)
             .HasForeignKey(SC => SC.CourseId)
             .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
