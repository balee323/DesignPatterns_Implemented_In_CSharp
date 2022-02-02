using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns.FactoryPatterns.AbstractFactoryPattern
{
    public class AbstractFactoryPatternInAction
    {
        private IComputerSystemFactory _desktopFactory = new DesktopComputerSystemFactory();
        private IComputerSystemFactory _mobileFactory = new MobileComputerSystemFactory();
      
        public void ShowAllComputerDisplays()
        {
            //create the display panels
            IDisplayPanel iBMDisplayPanel = _desktopFactory.CreateDisplayPanel(SystemType.IBM);
            IDisplayPanel Commodore64DisplayPanel = _desktopFactory.CreateDisplayPanel(SystemType.Commodore64);
            IDisplayPanel OneHertzSystemDisplayPanel = _desktopFactory.CreateDisplayPanel(SystemType.OneHertzSystem);

            IDisplayPanel androidDisplayPanel = _mobileFactory.CreateDisplayPanel(SystemType.Android);
            IDisplayPanel iphoneDisplayPanel = _mobileFactory.CreateDisplayPanel(SystemType.Iphone);

            //create the computer systems
            var systems = new List<IComputerSystem>
            {
                //object creating has been push off to the factories
                _desktopFactory.CreateComputerSystem(SystemType.IBM, Language.English, iBMDisplayPanel),
                _desktopFactory.CreateComputerSystem(SystemType.IBM),  //Defaults to English with IBM display
                _desktopFactory.CreateComputerSystem(SystemType.Commodore64, Language.German, Commodore64DisplayPanel),
                _desktopFactory.CreateComputerSystem(SystemType.OneHertzSystem, Language.German, OneHertzSystemDisplayPanel),
                _desktopFactory.CreateComputerSystem(SystemType.Android, Language.German, androidDisplayPanel), //Default to IBM
                _mobileFactory.CreateComputerSystem(SystemType.Android, Language.English, androidDisplayPanel),
                _mobileFactory.CreateComputerSystem(SystemType.Iphone, Language.German, iphoneDisplayPanel),
                _mobileFactory.CreateComputerSystem(SystemType.IBM, Language.English, iBMDisplayPanel) //defaults to Android (with IBMdisplayPanel
            };

            //power on a random few computer systems
            Random rand = new Random();        
            for(int i = 0; i < 3; i++)
            {
                var index = rand.Next(0, systems.Count - 1);
                while (systems[index].IsPoweredOn)
                {
                    index = rand.Next(0, systems.Count - 1);
                }
   
                systems[index].PowerOn();
                Thread.Sleep(20);
            }

            //display a name and text on each powered on system
            foreach (IComputerSystem system in systems)
            {
                system.PrintOutName("Brian");
                system.PrintOutMessage();
            }
        }

    }
}
