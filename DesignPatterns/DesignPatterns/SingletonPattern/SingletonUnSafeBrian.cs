using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    //Singleton Pattern (not thread safe)
    public class SingletonUnSafeBrian
    {
        private static SingletonUnSafeBrian _singletonUnSafeBrian = null;

        //notice use of private constructor
        private SingletonUnSafeBrian() {}

        public static SingletonUnSafeBrian GetBrian
        {
            get
            {
                if (_singletonUnSafeBrian is null)
                {
                    _singletonUnSafeBrian = new SingletonUnSafeBrian();
                }

                return _singletonUnSafeBrian;
            }
        }

    }
}
