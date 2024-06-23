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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.Id).HasName("DeptId");
            builder.Property(D => D.Id).UseIdentityColumn(100, 100);
            builder.Property(D => D.HiringDate).HasComputedColumnSql("GETDATE()");

            builder.HasOne(D => D.Instructor_Manager)
                .WithOne();
                
        }
    }
}
