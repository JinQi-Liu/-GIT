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
    public class AuthGroupEmployeeInfoMap : IEntityTypeConfiguration<AuthGroupEmployeeInfo>
    {
        public void Configure(EntityTypeBuilder<AuthGroupEmployeeInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property("Id").HasColumnName("ID");
            builder.ToTable("Auth_GroupEmployeeInfo");

            builder.HasOne(pt => pt.AuthGroup)
                .WithMany(p => p.AuthGroupEmployeeInfos)
                .HasForeignKey(pt => pt.AuthGroupID);

            builder.HasOne(pt => pt.HREmployeeInfo)
                .WithMany(t => t.AuthGroupEmployeeInfos)
                .HasForeignKey(pt => pt.HREmployeeInfoID);
        }
    }
}
