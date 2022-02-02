namespace DesignPatterns.FactoryPatterns.AbstractFactoryPattern
{
    //This uses object composition -- an interface
    public interface IComputerSystemFactory
    {
        //There's multiple Factory Methods.  This is the difference vs Factory Method Pattern.
        IComputerSystem CreateComputerSystem(SystemType systemType, Language language, IDisplayPanel displayPanel);
        IComputerSystem CreateComputerSystem(SystemType systemType);
        IDisplayPanel CreateDisplayPanel(SystemType systemType);
    }

    public class MobileComputerSystemFactory : IComputerSystemFactory
    {

        public IDisplayPanel CreateDisplayPanel(SystemType systemType)
        {
            if (systemType == SystemType.Android)
            {
                return new AndroidDisplayPanel(80, 30);
            }
            if (systemType == SystemType.Iphone)
            {
                return new IphoneDisplayPanel(80, 40);
            }

            //"Invalid mobile system, defaulting to Android";
            return new AndroidDisplayPanel(80, 30);
        }

        public  IComputerSystem CreateComputerSystem(SystemType systemType, Language language, IDisplayPanel displayPanel)
        {
            if (systemType == SystemType.Android)
            {
                return new Android(language, displayPanel);
            }
            if (systemType == SystemType.Iphone)
            { 
                return new IPhone(language, displayPanel);
            }

            //"Invalid mobile system, defaulting to Android";
            return new Android(language, displayPanel);
        }

        public IComputerSystem CreateComputerSystem(SystemType systemType)
        {
            return CreateComputerSystem(systemType, Language.English, new AndroidDisplayPanel(80, 30));
        }   
    }

    public class DesktopComputerSystemFactory : IComputerSystemFactory
    {
        public IDisplayPanel CreateDisplayPanel(SystemType systemType)
        {
            if (systemType == SystemType.IBM)
            {
                return new IMBDisplayPanel();
            }
            if (systemType == SystemType.Commodore64)
            {
                return new Commodore64DisplayPanel();
            }
            if (systemType == SystemType.OneHertzSystem)
            {
                return new OneHertzSystemDisplayPanel();
            }

            //"Invalid mobile system, defaulting to IBM";
            return new IMBDisplayPanel();
        }

        public IComputerSystem CreateComputerSystem(SystemType systemType, Language language, IDisplayPanel displayPanel)
        {
            if (systemType == SystemType.IBM)
            {
                return new IBM(language, displayPanel);
            }
            if (systemType == SystemType.Commodore64)
            {
                return new Commodore64(language, displayPanel);
            }
            if (systemType == SystemType.OneHertzSystem)
            {
                return new OneHertzSystem(language, displayPanel);
            }

            //"Invalid mobile system, defaulting to IBM";
            return new IBM(language, displayPanel);
        }

        public IComputerSystem CreateComputerSystem(SystemType systemType)
        {
            return CreateComputerSystem(systemType, Language.English, new IMBDisplayPanel());
        }   
    }

}
