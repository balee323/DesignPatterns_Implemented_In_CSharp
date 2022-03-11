using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns
{
    //Singleton Pattern (thread safe) 
    //The object handles its instantiation by itself. 
    public class SingletonSafeBrian
    {
        private static SingletonSafeBrian _singletonSafeBrian = null;

        //notice use of private constructor
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
