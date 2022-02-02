using System.Collections.Generic;

namespace DesignPatterns.FactoryPatterns.AbstractFactoryPattern
{
    public class AbstractFactoryPatternInAction
    {
        private IComputerSystemFactory _desktopFactory = new DesktopComputerSystemFactory();
        private IComputerSystemFactory _mobileFactory = new MobileComputerSystemFactory();
        private List<IComputerSystem> _systems;

        public void ShowAllComputerDisplays()
        {
            _systems = new List<IComputerSystem>
            {
                //object creating has been push off to the factories
                _desktopFactory.CreateComputerSystem(SystemType.IBM),  //Defaults to English
                _desktopFactory.CreateComputerSystem(SystemType.Commodore64, Language.German),
                _desktopFactory.CreateComputerSystem(SystemType.OneHertzSystem, Language.German),
                _desktopFactory.CreateComputerSystem(SystemType.Android, Language.German), //Default to IBM
                _mobileFactory.CreateComputerSystem(SystemType.Android, Language.English),
                _mobileFactory.CreateComputerSystem(SystemType.Iphone, Language.German)
            };

            foreach (IComputerSystem system in _systems)
            {
                system.PrintOutName("Brian");
                system.PrintOutMessage();
            }

        }


    }
}
