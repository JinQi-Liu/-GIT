using Abp.Domain.Repositories;
using MyProject.Service.EFCore.Entity;
using MyProject.Service.EFCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service.EFCore.RepositoryInterface.Auth
{
    public interface IAuthGroupEmployeeInfoRepository : IWMPRepositoryBase<AuthGroupEmployeeInfo>
    {
    }
}
