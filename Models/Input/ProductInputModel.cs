using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateWork.API.Models.Input
{
    public class ProductInputModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal SizeX { get; set; }
        public decimal SizeY { get; set; }
        public decimal SizeZ { get; set; }
        public decimal Weight { get; set; }
        public string Producer { get; set; }
        public int YearOfManufacture { get; set; }
        public int? MaxPower { get; set; }
        public int? NumberOfPrograms { get; set; }
        public bool? Grill { get; set; }
        public bool? BowlVolume { get; set; }
        public bool? WetCleaning { get; set; }
        public decimal? ContainerVolume { get; set; }
        public bool? Nozzle { get; set; }
        public bool? PossibilityOfAdjustment { get; set; }
        public bool? RemoteLaunch { get; set; }
        public int? MaxCleaningArea { get; set; }
        public decimal? OverallVolume { get; set; }
        public bool? Freezer { get; set; }
        public bool? IceMaker { get; set; }
        public bool? NoFrost { get; set; }
        public byte? NumberOfTemperatureZones { get; set; }
        public bool? WiFi { get; set; }
        public int? Diagonal { get; set; }
        public string OperatingSystem { get; set; }
        public bool? SmartTv { get; set; }
        public bool? Receiver { get; set; }
        public byte? NumberOfCores { get; set; }
        public string CPU { get; set; }
    }
}
