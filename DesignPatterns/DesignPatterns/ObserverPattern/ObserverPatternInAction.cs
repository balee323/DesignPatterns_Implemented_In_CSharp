using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    public class ObserverPatternInAction
    {
        ForSaleAlarm _forSaleAlarm;

        public ObserverPatternInAction()
        {
            _forSaleAlarm = new ForSaleAlarm();

            _forSaleAlarm.Subscribe(new SavvyShopperOne());
            _forSaleAlarm.Subscribe(new SavvyShopperTwo());
            _forSaleAlarm.Subscribe(new SavvyShopperThree());
         
        }

        public void BargainAlarm()
        {
            //kick off the bargins
            _forSaleAlarm.Notify();
        }

    }
}
