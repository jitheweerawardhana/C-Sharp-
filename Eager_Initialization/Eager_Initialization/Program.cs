using Eager_Initialization;
using System;


namespace SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();

            if (instance1 == instance2)
            {
                

            }
        }
}