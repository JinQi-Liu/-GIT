using Abp.EntityFrameworkCore;
using MyProject.Service.EFCore.Entity;
using MyProject.Service.EFCore.RepositoryInterface.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service.EFCore.Repository.Auth
{
    public class AuthGroupRepository : WMPRepositoryBase<AuthGroup> , IAuthGroupRepository
    {
        public AuthGroupRepository(IDbContextProvider<WMPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
