using DAL.DalApi;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalImplementation
{
    internal class menuService : IMenus
    {
        public void Create(Menu item)
        {
            dbcontext dbcontext = new dbcontext();
            dbcontext.Menus.Add(item);
        }

        public void Delete(Menu item)
        {
            throw new NotImplementedException();
        }

        public List<Menu> Read()
        {
            dbcontext dbcontext = new dbcontext();
            return dbcontext.Menus.ToList();
        }

        public void Update(Menu item)
        {
            throw new NotImplementedException();
        }
    }
}
