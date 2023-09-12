using System;
using System.Collections.Generic;

namespace Homework6CMPG_323.Models
{
    public partial class Service
    {
        public int ServiceId { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
