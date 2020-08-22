using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWork.API.Models.OutputModel.Product
{
    public class RobotVacuumCleanerOutputModel:ProductGeneralOutputModel
    {
        public bool? WetCleaning { get; set; }
        public decimal? ContainerVolume { get; set; }
        public bool? RemoteLaunch { get; set; }
        public int? MaxCleaningArea { get; set; }
    }
}
