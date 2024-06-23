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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
          builder.HasKey(S=>S.Id).HasName("StdId");
          builder.Property(S => S.Id).UseIdentityColumn(1, 1);
            builder.HasOne(S=>S.Department)
                .WithMany(D=>D.Students)
                .HasForeignKey(S=>S.DeptId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
