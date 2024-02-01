using DAL.DalApi;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalImplementation
{
    public class costomerService : ICostomers
    {
       
        public void Create(Costomer item)
        {
            dbcontext dbcontext = new dbcontext();
            dbcontext.Costomers.Add(item);
        }

        public void Delete(Costomer item)
        {
            throw new NotImplementedException();
        }

        public List<Costomer> Read()
        {
            dbcontext dbcontext = new dbcontext();
            return dbcontext.Costomers.ToList();
        }

        public void Update(Costomer item)
        {
            throw new NotImplementedException();
        }
    }
}
