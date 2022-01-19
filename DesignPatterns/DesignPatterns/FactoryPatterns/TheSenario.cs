using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class TheSenario
    {

        public Duck GoDuckHunting(Senario senario)
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

            return duck;
        }
    }

    public class Duck
    {
    }

    public class Mallard :Duck
    {
    }
    public class DecoyDuck :Duck
    {
    }
    public class RubberDuck :Duck
    {
    }

    public enum Senario
    {
        Picnic,
        Hunting,
        TakingBath
    }
}
