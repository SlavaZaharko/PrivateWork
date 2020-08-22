using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWork.API.Models.OutputModel.Product
{
    public class RefrigeratorOutputmodel:ProductGeneralOutputModel
    {
        public decimal? OverallVolume { get; set; }
        public bool? Freezer { get; set; }
        public bool? IceMaker { get; set; }
        public bool? NoFrost { get; set; }
    }
}
