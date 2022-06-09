using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
     class PlaneHawker : IAirplane
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int FlightRange { get; set; }
        public int FuelConsumption { get; set; }
        public int LoadCapacity { get; set; }
        public PlaneHawker()
        {
            Name = "Hawker 400";
            Capacity = 900;
            FlightRange = 600;
            FuelConsumption = 500;
            LoadCapacity = 300;
        }
    }
}
