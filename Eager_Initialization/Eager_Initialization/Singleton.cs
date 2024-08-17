using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eager_Initialization
{
    internal class Singleton
    {
        private static Singleton instance = new Singleton();

        private Singleton() 
        {
            Console.WriteLine("Singleton is Initialization");
        }

        public static Singleton GetInstance() {
            return instance;
        }

        public void DisplayMsg
    }
}
