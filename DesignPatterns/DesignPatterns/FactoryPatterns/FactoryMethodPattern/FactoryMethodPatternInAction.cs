using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPatterns.FactoryMethodPattern
{
    public class FactoryMethodPatternInAction
    {
        private ComputerSystemFactory _desktopFactory = new DesktopComputerSystemFactory();
        private ComputerSystemFactory _mobileFactory = new MobileComputerSystemFactory();
        private List<ComputerSystem> _systems; 

        public void ShowAllComputerDisplays()
        {
            _systems = new List<ComputerSystem>
            {
                //object creating has been push off to the factories
                _desktopFactory.CreateComputerSystem(SystemType.IBM),  //Defaults to English
                _desktopFactory.CreateComputerSystem(SystemType.Commodore64, Language.German),
                _desktopFactory.CreateComputerSystem(SystemType.OneHertzSystem, Language.German),
                _desktopFactory.CreateComputerSystem(SystemType.Android, Language.German), //Default to IBM
                _mobileFactory.CreateComputerSystem(SystemType.Android, Language.English), 
                _mobileFactory.CreateComputerSystem(SystemType.Iphone, Language.German)
            };

            foreach (ComputerSystem system in _systems)
            {
                system.PrintOutName("Brian");
                system.PrintOutMessage();
            }

        }

    }
}
