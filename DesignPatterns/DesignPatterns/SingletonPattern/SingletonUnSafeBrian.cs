using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    //Singleton Pattern (not thread safe)
    public class SingletonUnSafeBrian
    {
        //this must be static since the a static method uses this variable
        private static SingletonUnSafeBrian _singletonUnSafeBrian = null;

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
