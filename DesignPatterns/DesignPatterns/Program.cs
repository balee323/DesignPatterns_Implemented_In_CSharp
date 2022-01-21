using System;
using DesignPatterns.Examples_of_use;
using DesignPatterns.FactoryPattern;
using DesignPatterns.FactoryPatterns.FactoryMethodPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //**Singleton Design Pattern
            //new SingletonInAction();
            ClearConsole();


            //**Factory Design Pattern(s)
            TheProblem theProblem = new TheProblem();
            theProblem.PurchaseDuck(Senario.Hunting);
            ClearConsole();

            new FactoryMethodPatternInAction().ShowAllComputerDisplays();

            ClearConsole();



            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        }


        private static void ClearConsole()
        {
            Console.ResetColor();
            Console.Title = string.Empty;

        }
    }
}
