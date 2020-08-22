using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWork.API.Models.OutputModel.Product
{
    public class VacuumCleanerOutputModel:ProductGeneralOutputModel
    {
        public bool WetCleaning { get; set; }
        public decimal ContainerVolume { get; set; }
        public bool Nozzle { get; set; }
        public bool PossibilityOfAdjustment { get; set; }
    }
}
