﻿using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyProject.Service.EFCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service.EFCore
{
    public class WMPDbContext : AbpDbContext
    {
        public DbSet<AuthGroup> AuthGroups { get; set; }
        public DbSet<HREmployeeInfo> HREmployeeInfos { get; set; }

        public WMPDbContext(DbContextOptions<WMPDbContext> options)
            : base(options)
        {
        }
    }
}
