using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDB.Domain.Model.Orders
{
    public class Order:Common.Domain.IDomainEntity
    {
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = Guid.NewGuid().ToString();
            }
        }

        public static Order Create()
        {
            throw new Exception();
        }

        private string id;

    }
}
