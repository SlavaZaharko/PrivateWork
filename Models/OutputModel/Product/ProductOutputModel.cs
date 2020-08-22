using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWork.API.Models.OutputModel
{
    public class ProductGeneralOutputModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal SizeX { get; set; }
        public decimal SizeY { get; set; }
        public decimal SizeZ { get; set; }
        public decimal Weight { get; set; }
        public string Producer { get; set; }
        public int YearOfManufacture { get; set; }

    }
}
