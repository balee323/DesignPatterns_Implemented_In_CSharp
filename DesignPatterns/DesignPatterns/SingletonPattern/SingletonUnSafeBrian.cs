using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    //Singleton Pattern (not thread safe)
    //The object handles its instantiation by itself. 
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
                    //not thread safe here, there could be multiple instances (with one being garbage collected)
                    _singletonUnSafeBrian = new SingletonUnSafeBrian();
                }

                return _singletonUnSafeBrian;
            }
        }

    }
}
