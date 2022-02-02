namespace DesignPatterns.FactoryPatterns.AbstractFactoryPattern
{
    //This uses object composition -- an interface
    public interface IComputerSystemFactory
    {
        IComputerSystem CreateComputerSystem(SystemType systemType, Language language);
        IComputerSystem CreateComputerSystem(SystemType systemType);
    }

    public class MobileComputerSystemFactory : IComputerSystemFactory
    {
        public  IComputerSystem CreateComputerSystem(SystemType systemType, Language language)
        {
            if (systemType == SystemType.Android)
            {
                return new Android(language, 80, 30); //additional settings can be abstracted away
            }
            if (systemType == SystemType.Iphone)
            {
                return new IPhone(language, 80, 40);
            }

            //"Invalid mobile system, defaulting to Android";
            return new Android(language, 80, 30);
        }

        public IComputerSystem CreateComputerSystem(SystemType systemType)
        {
            return CreateComputerSystem(systemType, Language.English);
        }
    }


    public class DesktopComputerSystemFactory : IComputerSystemFactory
    {
        public IComputerSystem CreateComputerSystem(SystemType systemType, Language language)
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
            return new IBM(language);
        }

        public IComputerSystem CreateComputerSystem(SystemType systemType)
        {
            return CreateComputerSystem(systemType, Language.English);
        }

    }

}
