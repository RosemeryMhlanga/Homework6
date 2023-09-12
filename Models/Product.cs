using System;
using System.Collections.Generic;

namespace Homework6CMPG_323.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
