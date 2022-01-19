using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns
{
    //Singleton Pattern (not thread safe)
    public class SingletonSafeBrian
    {
        //this must be static since the a static method uses this variable
        private static SingletonSafeBrian _singletonSafeBrian = null;

        private SingletonSafeBrian() {}

        public static SingletonSafeBrian Blee
        {
            get
            {
                bool lockTaken = false; 
                Monitor.Enter(_singletonSafeBrian, ref lockTaken);

                if (_singletonSafeBrian is null)
                {
                    _singletonSafeBrian = new SingletonSafeBrian();
                }

                Monitor.Exit(_singletonSafeBrian);
                return _singletonSafeBrian;
            }
        }

    }
}
