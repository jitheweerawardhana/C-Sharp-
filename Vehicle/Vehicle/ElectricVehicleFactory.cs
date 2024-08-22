using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class ElectricVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new ElectricCar();
        }

        public IVehicle CreateTruck()
        {
            return new ElectricTruck();
        }

        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }
    }
}
