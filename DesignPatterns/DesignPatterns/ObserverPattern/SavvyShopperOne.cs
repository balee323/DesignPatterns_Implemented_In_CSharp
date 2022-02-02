using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    internal class SavvyShopperOne : IWatcher<ForSaleAlarm>
    {
        public void BargainAlert(ForSaleAlarm forSaleAlarm)
        {
            Console.WriteLine("I am on my way!!!");
        }
    }
}
