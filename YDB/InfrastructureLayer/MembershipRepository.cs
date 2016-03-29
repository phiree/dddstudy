using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YDB.Domain.Model.IdentityAccess;
namespace YDB.InfrastructureLayer
{
  public  class MembershipRepository
    {
        Common.Repository.IRepository< Membership> repository;
        public MembershipRepository(Common.Repository.IRepository<Membership> repository)
        {
            this.repository = repository;
        }
        public void Add(Membership member)
        {
            this.repository.Add(member);
        }
    }
}
