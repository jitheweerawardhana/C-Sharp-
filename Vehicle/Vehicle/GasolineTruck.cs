﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class GasolineTruck : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Gasoline Truck");
        }
    }
}
