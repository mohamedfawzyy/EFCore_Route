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
    internal class CousrseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(C => C.Id).HasName("CourseId");
            builder.Property(C=>C.Id).UseIdentityColumn(10,10);
            builder.HasOne(C=>C.Topic).WithMany(T=>T.Courses)
                .HasForeignKey(C=>C.TopicId).IsRequired(true);



        }
    }
}
