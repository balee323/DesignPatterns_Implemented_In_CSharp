using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    internal class SavvyShopperTwo : IWatcher<ForSaleAlarm>
    {
        public void BargainAlert(ForSaleAlarm forSaleAlarm)
        {
            Console.WriteLine("I have been waiting on that item.  Please hold it for me!");
        }
    }
}
