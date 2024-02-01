using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Dish
    {
        public int Id { get; set; }
        public string? NameOfdish { get; set; }
        public int? Price { get; set; }
        public string? Typeofmeno { get; set; }
        public byte[]? Picture { get; set; }
    }
}
