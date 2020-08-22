using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWork.API.Models.OutputModel.Product
{
    public class MulticookerOutputModel:ProductGeneralOutputModel
    {
        public int MaxPower { get; set; }
        public int NumberOfPrograms { get; set; }
        public decimal BowlVolume { get; set; }
    }
}
