using Microsoft.AspNetCore.Mvc;
using BL;
using BL.BlImplementation;
using DAL.Models;
using BL.BlModels;

namespace MyServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CostomerController : Controller
    {
        BlCostomerService costomerService = new BlCostomerService();

        [HttpGet]
        [Route("GetCostomer")]
        public List<BlCostomer> getCostomers()
        {
            return costomerService.Read();
        }
        
    }
}
