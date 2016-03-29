using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YDB.Domain.Model.Orders;

namespace YDB.Application.Orders
{
   public class OrderService : IOrderService
    {
        YDB.InfrastructureLayer.OrderRepository repo;
        public OrderService(YDB.InfrastructureLayer.OrderRepository repo)
        {
            this.repo = repo;
        }
        public void Create(Order order)
        {
            repo.Add(order);
        }
    }
}
