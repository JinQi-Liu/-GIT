
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProject.Service.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service
{
    [DependsOn(
        typeof(MyProjectServiceEFCoreModule))]
    public class MyProjectServiceModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProjectServiceModule).GetAssembly());
        }
    }
}
