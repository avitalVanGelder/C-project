using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string? NameOfCustomer { get; set; }
        public string? Adress { get; set; }
        public string? PhoneNumber { get; set; }
        public int? Finalprice { get; set; }
    }
}
