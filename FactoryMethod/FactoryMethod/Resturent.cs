using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Resturent
    {
        public Burger OrderBurger()
        {
            Burger burger = CreateBurger();
            burger.Prepare();
            return burger;  
        }

        public abstract Burger CreateBurger();
    }
}
