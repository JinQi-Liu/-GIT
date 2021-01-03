using Abp.Domain.Repositories;
using MyProject.EFCore.Entity;
using MyProject.EFCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.EFCore.RepositoryInterface.Auth
{
    public interface IAuthGroupEmployeeInfoRepository : IWMPRepositoryBase<AuthGroupEmployeeInfo>
    {
    }
}
