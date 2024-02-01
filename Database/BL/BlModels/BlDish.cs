using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlModels
{
    internal class BlDish
    {
        public int Id { get; set; }
        public string? NameOfdish { get; set; }
        public int? Price { get; set; }
        public string? Typeofmeno { get; set; }
        public string? GlutenFree { get; set; }
    }
}
