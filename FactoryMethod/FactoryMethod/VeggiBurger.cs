using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class VeggiBurger : Burger
    {
        public override void Prepare()
        {
            Console.WriteLine("VeggiBurger");
        }
    }
}
