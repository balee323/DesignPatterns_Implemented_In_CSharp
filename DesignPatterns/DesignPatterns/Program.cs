using System;
using DesignPatterns.AdapterPattern.ObjectAdapters.DataModelExample;
using DesignPatterns.Examples_of_use;
using DesignPatterns.FactoryPattern;
using DesignPatterns.FactoryPatterns.AbstractFactoryPattern;
using DesignPatterns.FactoryPatterns.FactoryMethodPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //**Factory Design Pattern(s)
            //TheProblem theProblem = new TheProblem();
            //theProblem.PurchaseDuck(Senario.Hunting);
            ClearConsole();
            //new FactoryMethodPatternInAction().ShowAllComputerDisplays();
            ClearConsole();
            //new AbstractFactoryPatternInAction().ShowAllComputerDisplays();
            ClearConsole();


            //**Adapter Pattern
            //var bankStatement =  new DataModelAdapter_InAction().GetBankStatement();



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
