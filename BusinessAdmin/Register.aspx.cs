﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YDB.Application.IdentityAccess.Memberships;
using YDB.Application.Orders;
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
            new YDB.InfrastructureLayer.MembershipRepository(new NHibernateRepository<Membership>("jsyk_membership_conn")));
             
        MembershipDto dto = new MembershipDto { Password = tbxPassword.Text, UserName = tbxUserName.Text };
        m.Register(dto);

        IOrderService orderService = new OrderService(new YDB.InfrastructureLayer.OrderRepository(
            new NHibernateRepository<YDB.Domain.Model.Orders.Order>("jsyk_order_conn")
            ));
        orderService.Create( YDB.Domain.Model.Orders.Order.Create());


    }
}