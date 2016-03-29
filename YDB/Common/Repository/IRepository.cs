using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YDB.Common.Specification;
namespace YDB.Common.Repository
{
   public   interface IRepository<TEntity>
        where TEntity:Domain.IDomainEntity
    {
        TEntity FindById(Guid id);
        TEntity FindOne(ISpecification<TEntity> spec);
        IEnumerable<TEntity> Find(ISpecification<TEntity> spec);
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
