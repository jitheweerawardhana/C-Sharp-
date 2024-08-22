using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting Electric Engine");
        }
    }
}
