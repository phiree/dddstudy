using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace YDB.InfrastructureLayer.NHibernateImpl.Mapping
{
    public class EntityMap<T>:ClassMap<T>
        where T :Common.Domain.IDomainEntity
    {
        public EntityMap()
        {
            Id(x => x.Id);
        }
    }
}
