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
    public class AuthGroupMap : IEntityTypeConfiguration<AuthGroup>
    {
        public void Configure(EntityTypeBuilder<AuthGroup> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property("Id").HasColumnName("ID");
            builder.ToTable("Auth_Group");
            builder.Property(x => x.GroupName).IsRequired().HasMaxLength(20);
        }
    }
}
