using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWork.API.Models.OutputModel.Product
{
    public class TvOutputModel:ProductGeneralOutputModel
    {
        public bool WiFi { get; set; }
        public int Diagonal { get; set; }
        public bool SmartTv { get; set; }
        public bool Receiver { get; set; }
    }
}
