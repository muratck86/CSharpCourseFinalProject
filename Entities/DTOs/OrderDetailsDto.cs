using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class OrderDetailsDto
    {
        public int OrderId { get; set; }
        public string ContactName { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }

    }
}
