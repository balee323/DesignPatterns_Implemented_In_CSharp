using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{ 
    //this is the subject object (publisher)
    public class ForSaleAlarm
    {
        //Microsoft has concept of this built-in:  IObservable and IObserver
        private List<IWatcher<ForSaleAlarm>> watchers = new List<IWatcher<ForSaleAlarm>>();

        public void Subscribe(IWatcher<ForSaleAlarm> watcher)
        {
            watchers.Add(watcher);
        }

        public void Notify()
        {
            foreach  (var watcher in watchers)
            {
                watcher.BargainAlert(this);
            }
        }

    }
}
