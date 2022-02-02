using System;

namespace DesignPatterns.FactoryPatterns.SimpleFactoryPattern
{
    //The problem here is that the Shopping cart should be worried with 
    //creation of the actual duck.  Shopping cart should only worry with getting the cost
    public class ShoppingCart
    {
        public void BuyDuck(Senario senario)
        {
            Duck duck = null;

            //This is unfavorable:
            if (senario == Senario.Picnic)
            {
                duck = new Mallard();
            }
            else if (senario == Senario.Hunting)
            {
                duck = new DecoyDuck();
            }
            else if (senario == Senario.TakingBath)
            {
                duck = new RubberDuck();
            }

            Console.WriteLine($"For {senario}, you will need a {duck} and it will cost ${duck.Cost}.");
        }
    }
}
