using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWork.API.Models.OutputModel
{
    public class OrderInfoOutputModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public int Quantity { get; set; }
        public decimal TotalValue { get; set; }
    }
}
