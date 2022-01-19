using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{

    public class TheProblem
    {

        //Let's go buy a duck.
        private readonly ShoppingCart _shoppingCart = new ShoppingCart();

        public void PurchaseDuck(Senario senario)
        {
            _shoppingCart.BuyDuck(senario);
        }

    }


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

    public abstract class Duck
    {
        public abstract decimal Cost { get; }
    }

    public class Mallard : Duck
    {
        public override decimal Cost => 75.95m;
    }
    public class DecoyDuck :Duck
    {
        public override decimal Cost => 29.99m;
    }
    public class RubberDuck :Duck
    {
        public override decimal Cost => 2.99m;
    }

    public enum Senario
    {
        Picnic,
        Hunting,
        TakingBath
    }
}
