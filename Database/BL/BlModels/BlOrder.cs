using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlModels
{
    internal class BlOrder
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string? NameOfCustomer { get; set; }
        public string? Adress { get; set; }
        public string? PhoneNumber { get; set; }
        public int? Finalprice { get; set; }
        public int? Weight { get; set; }
    }
}
