using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YDB.Application.IdentityAccess.Memberships;
using YDB.Domain.Model.IdentityAccess;
using YDB.InfrastructureLayer.NHibernateImpl;
public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnRegister_Click(object sender, EventArgs e)
    {
        IMembershipService m = new MembershipService(
            new YDB.InfrastructureLayer.MembershipRepository(new NHibernateRepository<Membership>())
            );
        MembershipDto dto = new MembershipDto { Password = tbxPassword.Text, UserName = tbxUserName.Text };
        m.Register(dto);

    }
}