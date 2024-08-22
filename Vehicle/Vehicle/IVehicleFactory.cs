using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public interface IVehicleFactory
    {
        IVehicle CreateCar();
        IVehicle CreateTruck();
        IEngine CreateEngine();
    }
}
