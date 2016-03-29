using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDB.Domain.Resource.Models.Businesses
{
    /// <summary>
    /// 商家
    /// </summary>
   public class Business
    {
        public string Id { get; protected set; }
        public ContactInfo ContactInfo { get; protected set; }
        
    }
}
