using System;

namespace DesignPatterns.FactoryPatterns.SimpleFactoryPattern
{
    //The problem here is that the Shopping cart should be worried with 
    //creation of the actual duck.  Shopping cart should only worry with getting the cost
    public class ShoppingCart_WithFactory
    {
        public void BuyDuck(Senario senario)
        {
            Duck duck = null;

            SimpleFactory simpleFactory = new SimpleFactory();
            
            duck = simpleFactory.CreateDuck(senario);
  
            Console.WriteLine($"For {senario}, you will need a {duck} and it will cost ${duck.Cost}.");
        }
    }
}
