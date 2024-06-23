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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(I=>I.Id).HasName("InsId");
            builder.Property(I => I.Id).UseIdentityColumn(10, 10);
            builder.HasOne(I => I.Department)
                .WithMany(D => D.Instructors)
                .HasForeignKey(I => I.DeptId)
                .IsRequired(true);
        }
    }
}
