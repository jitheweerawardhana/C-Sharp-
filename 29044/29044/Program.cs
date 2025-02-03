using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _29044
{
    class program
    {
        public static void Main(string[] args)
        {
            HandleInputs(args);
        }

        static bool isRunning = true;

        static void HandleInputs(string[] args)

        {
            while (isRunning)
            {
                Console.WriteLine("**********************");
                Console.WriteLine("recursin and iteration");
                Console.WriteLine("please enter your option : ");
                Console.WriteLine("\t1.find Factorial");
                Console.WriteLine("\t2.find fibonachi");
                Console.WriteLine("\t3.find GCD");
                Console.WriteLine("\t4.Binary Serch");
                Console.WriteLine("\t5.Exit");

                string optionalInput = Console.ReadLine();
                //swich acase handler

                switch (optionalInput)
                {
                    case "1":
                        handleFactorial();
                        break;

                    case "2":
                        handleFibonachi();
                        break;

                    case "3":
                        handleGCD();
                        break;

                    case "5":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }

        }


        static void handleFactorial()
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            FactorialFinder factorialFinder = new FactorialFinder();
            Console.WriteLine();

            Console.WriteLine("Factorial Finder");
            long result = factorialFinder.Factorial(number);
            Console.WriteLine("Factorial" + " " + number + " " + "is" + " " + result);
            Console.WriteLine();

            Console.WriteLine("Factorial iterative Finder");
            long newReslut = factorialFinder.IterativeFactorial(number);
            Console.WriteLine("Factorial" + " " + number + " " + "is" + " " + newReslut);
            Console.WriteLine();
        }

        static void handleFibonachi()
        {

            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Fibonachi fibonachi = new Fibonachi();
            Console.WriteLine();

            Console.WriteLine("Fibonachi Finder");
            long resultfibo = fibonachi.RecursiveFibonacci(number);
            Console.WriteLine("fibonachi" + " " + number + " " + "is" + " " + resultfibo);
            Console.WriteLine();

            Console.WriteLine("Iterative Fibonachi Approch");
            long resultIteratve = fibonachi.IterativeFibonacci(number);
            Console.WriteLine("Iterative fibonachi" + " " + number + " " + "is" + " " + resultIteratve);
            Console.WriteLine();
        }

        static void handleGCD()
        {
            Console.WriteLine("Enter the number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            GCDFinder finder = new GCDFinder();
            Console.WriteLine();

            Console.WriteLine("GCD finder Iterative");
            long resultGCD = finder.IterativeGCD(number1, number2);
            Console.WriteLine("Iterative GCD" + " " + (number1 + " " + number2) + " " + "is" + " " + resultGCD);
            Console.WriteLine();

            Console.WriteLine("GCD finder Recursive ");
            long resultGCDRec = finder.IterativeGCD(number1, number2);
            Console.WriteLine("Recursive GCD" + " " + (number1 + " " + number2) + " " + "is" + " " + resultGCDRec);
            Console.WriteLine();

        }

    }
}



