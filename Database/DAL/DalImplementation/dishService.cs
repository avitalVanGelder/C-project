using DAL.DalApi;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalImplementation
{
    internal class dishService : IDishes
    {
        public void Create(Dish item)
        {
            dbcontext dbcontext = new dbcontext();
            dbcontext.Dishes.Add(item);
        }

        public void Delete(Dish item)
        {
            throw new NotImplementedException();
        }

        public List<Dish> Read()
        {
            dbcontext dbcontext = new dbcontext();
            return dbcontext.Dishes.ToList();
        }

        public void Update(Dish item)
        {
            throw new NotImplementedException();
        }
    }
}
