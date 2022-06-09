using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
     class PlaneMriya : IAirplane
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int FlightRange { get; set; }
        public int FuelConsumption { get; set; }
        public int LoadCapacity { get; set; }
        public PlaneMriya()
        {
            Name = "Antonov An-225 Mriya";
            Capacity = 800;
            FlightRange = 200;
            FuelConsumption = 700;
            LoadCapacity = 1000;
        }
    }
}
