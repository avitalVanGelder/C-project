using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Costomer
    {
        public int Id { get; set; }
        public string? PhonNumber { get; set; }
        public string? FullName { get; set; }
        public string? City { get; set; }
    }
}
