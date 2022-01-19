using System;
using DesignPatterns.Examples_of_use;
using DesignPatterns.FactoryPatterns.FactoryMethodPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //new SingletonInAction();

            new FactoryMethodPatternInAction().ShowAllComputerDisplays();

            Console.ResetColor();
            Console.Title = string.Empty;
            Console.WriteLine("press any key to exit.");
            Console.ReadKey();

        }
    }
}
