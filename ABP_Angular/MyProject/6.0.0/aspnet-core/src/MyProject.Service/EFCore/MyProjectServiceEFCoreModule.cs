using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Zero.EntityFrameworkCore;
using MyProject.Service.EFCore.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service.EFCore
{
    [DependsOn(
        typeof(MyProjectCoreModule),
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    class MyProjectServiceEFCoreModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<WMPDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        WMPDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        WMPDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
