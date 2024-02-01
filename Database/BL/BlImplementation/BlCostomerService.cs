using BL.BlApi;
using BL.BlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DalImplementation;
using DAL.Models;
namespace BL.BlImplementation
{
    public class BlCostomerService : BlICostomers
    {
        public void Create(BlCostomer item)
        {
            costomerService costomerService = new costomerService();
            costomerService.Create(new Costomer() {
                City = item.City,
                FullName = item.FullName,
                Id = item.Id,
                PhonNumber = item.PhonNumber 
            });
        }

        public void Delete(BlCostomer item)
        {
            throw new NotImplementedException();
        }

        public List<BlCostomer> Read()
        {
            costomerService costomerService = new costomerService();
            List<BlCostomer> list = new();
            costomerService.Read().ForEach(c =>
            list.Add(new BlCostomer() {
                Id = c.Id,
                FullName = c.FullName,
                City = c.City,
                PhonNumber = c.PhonNumber
            })
          );
            return list;    
        }

        public void Update(BlCostomer item)
        {
            throw new NotImplementedException();
        }
    }
}
