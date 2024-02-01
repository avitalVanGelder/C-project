using DAL.DalApi;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalImplementation
{
    internal class orderService : IOrders
    {
        public void Create(Order item)
        {
            dbcontext dbcontext = new dbcontext();
            dbcontext.Orders.Add(item);
        }

        public void Delete(Order item)
        {
            throw new NotImplementedException();
        }

        public List<Order> Read()
        {
            dbcontext dbcontext = new dbcontext();
            return dbcontext.Orders.ToList();
        }

        public void Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
