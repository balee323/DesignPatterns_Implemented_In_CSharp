using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    internal class SavvyShopperThree : IWatcher<ForSaleAlarm>
    {
        public void BargainAlert(ForSaleAlarm forSaleAlarm)
        {
            Console.WriteLine("I'll pass, thanks.");
        }
    }
}
