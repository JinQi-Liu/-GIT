using Abp.Dependency;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.EFCore.Repository
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class WMPRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<WMPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected WMPRepositoryBase(IDbContextProvider<WMPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="WMPRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class WMPRepositoryBase<TEntity> : WMPRepositoryBase<TEntity, Guid>, IWMPRepositoryBase<TEntity>
        where TEntity : class, IEntity<Guid>
    {
        protected WMPRepositoryBase(IDbContextProvider<WMPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }

    public interface IWMPRepositoryBase<TEntity>: IRepository<TEntity, Guid>, IRepository, ITransientDependency where TEntity : class, IEntity<Guid>
    {

    }
}
