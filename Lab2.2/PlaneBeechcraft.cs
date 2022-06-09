using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
     class PlaneBeechcraft : IAirplane
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int FlightRange { get; set; }
        public int FuelConsumption { get; set; }
        public int LoadCapacity { get; set; }
        public PlaneBeechcraft()
        {
            Name = "Beechcraft Premier";
            Capacity = 200;
            FlightRange = 900;
            FuelConsumption = 400;
            LoadCapacity = 100;
        }
    }
}
