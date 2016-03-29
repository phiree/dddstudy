using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YDB.Common.Specification;
using NHibernate;
namespace YDB.InfrastructureLayer.NHibernateImpl
{
    public class NHibernateRepository<T> : Common.Repository.IRepository<T>
        where T : Common.Domain.IDomainEntity
    {
        ISession session;
        public NHibernateRepository()
        {
          session= new HybridSessionBuilder().GetSession();
        }
        public void Add(T entity)
        {
            using (var t = session.BeginTransaction())
            { 
                session.Save(entity);
                t.Commit();
            }
        }

        public IEnumerable<T> Find(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public T FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public T FindOne(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
