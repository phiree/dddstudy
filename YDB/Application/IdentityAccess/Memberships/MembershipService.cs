using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YDB.Domain.Model.IdentityAccess;
namespace YDB.Application.IdentityAccess.Memberships
{
    public class MembershipService : IMembershipService
    {
        InfrastructureLayer.MembershipRepository repo;
        public MembershipService(InfrastructureLayer.MembershipRepository repo)
        {
            this.repo = repo;
        }
        public MembershipDto Register(MembershipDto membership)
        {
            Membership m = Membership.Create(membership.UserName, membership.Password);
            repo.Add(m);
            return new MembershipDto {UserName=m.UserName,Password=m.Password };
        }
    }
}
