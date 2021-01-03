using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.EntityFrameworkCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.EntityFrameworkCore.Mapper
{
    public class HREmployeeInfoMap : IEntityTypeConfiguration<HREmployeeInfo>
    {
        public void Configure(EntityTypeBuilder<HREmployeeInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property("Id").HasColumnName("ID");
            builder.ToTable("HR_EmployeeInfo");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        }
    }
}
