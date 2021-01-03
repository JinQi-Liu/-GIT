using Abp.Dependency;
using MyProject.Service.EFCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service.ServiceInterface.Auth
{
    public interface IAuthGroupEmployeeInfoService: ITransientDependency
    {
        List<HREmployeeInfo> Test();
    }
}
