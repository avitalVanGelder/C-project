using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlModels
{
    public class BlCostomer
    {
        public int Id { get; set; }
        public string? PhonNumber { get; set; }
        public string? FullName { get; set; }
        public string? City { get; set; }
        public DateTime? DateOfOrder { get; set; }
    }
}
