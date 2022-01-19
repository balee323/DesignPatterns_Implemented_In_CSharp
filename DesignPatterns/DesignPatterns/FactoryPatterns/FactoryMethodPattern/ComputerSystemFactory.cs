using System;

namespace DesignPatterns.FactoryPatterns.FactoryMethodPattern
{

    public enum SystemType
    {
        IBM,
        OneHertzSystem,
        Commodore64,
        Android,
        Iphone
    }

    public enum Language
    {
        English,
        German
    }


    //This uses inheritance -- implementing via subclass classes
    public abstract class ComputerSystemFactory
    {
        protected Language _langauge = Language.English; //Defaults to English
        public abstract ComputerSystem CreateComputerSystem(SystemType systemType, Language language);
        public abstract ComputerSystem CreateComputerSystem(SystemType systemType);
    }


    public class MobileComputerSystemFactory : ComputerSystemFactory
    {
        public override ComputerSystem CreateComputerSystem(SystemType systemType, Language language)
        {

            if (systemType == SystemType.Android)
            {
                return new Android(Language.German, 80, 30); //additional settings can be abstracted away
            }
            if (systemType == SystemType.Iphone)
            {
                return new IPhone(Language.English, 80, 40);
            }
           
            //"Invalid mobile system, defaulting to Android";
            return new Android(Language.English, 80, 30);
        }

        public override ComputerSystem CreateComputerSystem(SystemType systemType)
        {
            return CreateComputerSystem(systemType, base._langauge);
        }
    }

    public class DesktopComputerSystemFactory : ComputerSystemFactory
    {
        public override ComputerSystem CreateComputerSystem(SystemType systemType, Language language)
        {
            if (systemType == SystemType.IBM)
            {
                return new IBM(language);
            }
            if (systemType == SystemType.Commodore64)
            {
                return new Commodore64(language);
            }
            if (systemType == SystemType.OneHertzSystem)
            {
                return new OneHertzSystem(language);
            }

            //"Invalid mobile system, defaulting to IBM";
            return new IBM(Language.English);
        }

        public override ComputerSystem CreateComputerSystem(SystemType systemType)
        {
            return CreateComputerSystem(systemType, base._langauge);
        }

    }

}
