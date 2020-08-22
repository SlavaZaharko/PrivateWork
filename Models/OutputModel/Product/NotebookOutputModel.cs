using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWork.API.Models.OutputModel.Product
{
    public class NotebookOutputModel:ProductGeneralOutputModel
    {
        public bool WiFi { get; set; }
        public int Diagonal { get; set; }
        public string OperatingSystem { get; set; }
        public byte NumberOfCores { get; set; }
        public string CPU { get; set; }
    }
}
