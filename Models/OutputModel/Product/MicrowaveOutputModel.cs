using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWork.API.Models.OutputModel.Product
{
    public class MicrowaveOutputModel: ProductGeneralOutputModel
    {
        public int MaxPower { get; set; }
        public int NumberOfPrograms { get; set; }
        public bool? Grill { get; set; }
    }
}
