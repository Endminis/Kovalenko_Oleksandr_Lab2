using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
     interface IAirplane
    {
        string Name { get; set; }
        int Capacity { get; set; } 
        int FlightRange { get; set; } 
        int FuelConsumption { get; set; }
        int LoadCapacity { get; set; }
    }
}
