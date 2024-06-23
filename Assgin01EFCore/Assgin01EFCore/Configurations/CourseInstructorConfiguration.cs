using Assgin01EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Assgin01EFCore.Configurations
{
    internal class CourseInstructorConfiguration : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> builder)
        {
            builder.HasKey(CI => new { CI.CourseId, CI.InstId });
            builder.HasOne(CI=>CI.Course)
                .WithMany(C=>C.CourseInstructors)
                .HasForeignKey(CI=>CI.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(CI => CI.Instructor)
                .WithMany(I => I.CourseInstructors)
                .HasForeignKey(CI => CI.InstId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
