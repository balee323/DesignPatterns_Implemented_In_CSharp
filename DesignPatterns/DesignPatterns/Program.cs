using System;
using DesignPatterns.AdapterPattern;
using DesignPatterns.AdapterPattern.ObjectAdapters;
using DesignPatterns.AdapterPattern.ObjectAdapters.DataModelExample;
using single = DesignPatterns.DecoratorPattern.DecoratedStockGrabber;
using multi = DesignPatterns.DecoratorPattern.MultiDecoratedStockGrabber;
using DesignPatterns.FactoryPatterns.AbstractFactoryPattern;
using DesignPatterns.FactoryPatterns.FactoryMethodPattern;
using DesignPatterns.FactoryPatterns.SimpleFactoryPattern;
using DesignPatterns.ObserverPattern;
using Microsoft.Extensions.Caching.Memory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ClearConsole();

            //=================================================================================
            //** Singleton -- not running code for this one



            //=================================================================================
            //** Decorator

            //show stock grabber without decorator(s)

            //---Single decorator (add a logger)
            single.IAlphaVantageClient _clientWithLogger = new single.AlphaVantageLoggingDecorator(new single.AlphaVantageClient());
            var stockdata = _clientWithLogger.GetLatestStockData("AMD").Result;

            ;
            //---Multi decorator (logger and memory cache)
            IMemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());
            //build it like an onion
            multi.IAlphaVantageClient client = new multi.AlphaVantageClient();
            multi.IAlphaVantageClient clientWithLogger = new multi.AlphaVantageLoggingDecorator(client);
            multi.IAlphaVantageClient _clientWithCache = new multi.AlphaVantageCachingDecorator(clientWithLogger, memoryCache);



            //=================================================================================
            //**Factory Design Pattern(s)
            //SimpleFactoryInAction simpleFactoryInAction = new SimpleFactoryInAction();
            //simpleFactoryInAction.PurchaseDuck(Senario.TakingBath);
            //simpleFactoryInAction.PurchaseDuckUsingFactory(Senario.Picnic);

            //theProblem.PurchaseDuck(Senario.Hunting);
            ClearConsole();
            //new FactoryMethodPatternInAction().ShowAllComputerDisplays();
            ClearConsole();
            //new AbstractFactoryPatternInAction().ShowAllComputerDisplays();
            ClearConsole();


            //=================================================================================
            //**Adapter Pattern

            //this is not actually wired up, so don't run, only show starting with the problem
            //var bankAccount = new Bank().FetchData(Source.FromAPI);

            //var bankStatement =  new DataModelAdapter_InAction().GetBankStatement();


            //=================================================================================
            //**Observer pattern
            //new ObserverPatternInAction().BargainAlarm();


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
