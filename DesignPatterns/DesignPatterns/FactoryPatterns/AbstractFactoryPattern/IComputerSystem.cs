using System;
using System.Threading;

namespace DesignPatterns.FactoryPatterns.AbstractFactoryPattern
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


    public interface IComputerSystem
    {
        void PowerOn();
        void PowerOff();
        void PrintOutName(string name);
        void PrintOutMessage();
        bool IsPoweredOn { get; }
    }


    public class Commodore64 : IComputerSystem
    {
        private Language _language;
        private IDisplayPanel _displayPanel;

        public bool IsPoweredOn { get; private set;} = false;
        public Commodore64(Language language, IDisplayPanel displayPanel)
        {
            _language = language;
            _displayPanel = displayPanel;
        }

        public void PowerOn()=> IsPoweredOn = true;
        public void PowerOff() => IsPoweredOn = false;

        public void PrintOutMessage()
        {
            if (_language == Language.German && IsPoweredOn)
            {
                _displayPanel.DisplayText("Hallo, dies ist eine Demo für die PrintLine API.");
                _displayPanel.DisplayText("Diese Meldung erscheint im Kompatibilitätsmodus für jedes System.");
            }
            else if (IsPoweredOn)
            {
                _displayPanel.DisplayText("Hello, this is a demo for PrintLine API.");
                _displayPanel.DisplayText("This is message is appearing in compatibility mode for each system.");
            }
        }

        public void PrintOutName(string name)
        {
            if (IsPoweredOn)
                _displayPanel.DisplayText(name);
        }
    }


    public class IBM : IComputerSystem
    {
        private Language _language;
        private IDisplayPanel _displayPanel;
        public bool IsPoweredOn { get; private set; } = false;
        public IBM(Language language, IDisplayPanel displayPanel)
        {
            _language = language;
            _displayPanel = displayPanel;
        }

        public void PowerOn() => IsPoweredOn = true;
        public void PowerOff() => IsPoweredOn = false;

        public void PrintOutMessage()
        {
            if (_language == Language.German && IsPoweredOn)
            {
                _displayPanel.DisplayText("Hallo, dies ist eine Demo für die PrintLine API.");
                _displayPanel.DisplayText("Diese Meldung erscheint im Kompatibilitätsmodus für jedes System.");
            }
            else if (IsPoweredOn)
            {
                _displayPanel.DisplayText("Hello, this is a demo for PrintLine API.");
                _displayPanel.DisplayText("This is message is appearing in compatibility mode for each system.");
            }
        }

        public void PrintOutName(string name)
        {
            if (IsPoweredOn)
                _displayPanel.DisplayText(name);
        }
    }


    public class OneHertzSystem : IComputerSystem
    {
        private Language _language;
        private IDisplayPanel _displayPanel;
        public bool IsPoweredOn { get; private set; } = false;

        public OneHertzSystem(Language language, IDisplayPanel displayPanel)
        {
            _language = language;
            _displayPanel = displayPanel;
        }

        public void PowerOn() => IsPoweredOn = true;
        public void PowerOff() => IsPoweredOn = false;

        public void PrintOutMessage()
        {
            if (_language == Language.German && IsPoweredOn)
            {
                _displayPanel.DisplayText("Hallo, dies ist eine Demo für die PrintLine API.");
                _displayPanel.DisplayText("Diese Meldung erscheint im Kompatibilitätsmodus für jedes System.");
            }
            else if (IsPoweredOn)
            {
                _displayPanel.DisplayText("Hello, this is a demo for PrintLine API.");
                _displayPanel.DisplayText("This is message is appearing in compatibility mode for each system.");
            }
        }

        public void PrintOutName(string name)
        {
            if (IsPoweredOn)
                _displayPanel.DisplayText(name);
        }
    }


    public class Android : IComputerSystem
    {
        private Language _language;
        private IDisplayPanel _displayPanel;
        public bool IsPoweredOn { get; private set; } = false;

        public Android(Language language, IDisplayPanel displayPanel)
        {
            _language = language;
            _displayPanel = displayPanel;
        }

        public void PowerOn() => IsPoweredOn = true;
        public void PowerOff() => IsPoweredOn = false;

        public void PrintOutMessage()
        {
            if (_language == Language.German && IsPoweredOn)
            {
                _displayPanel.DisplayText("Hallo, dies ist eine Demo für die PrintLine API.");
                _displayPanel.DisplayText("Diese Meldung erscheint im Kompatibilitätsmodus für jedes System.");
            }
            else if (IsPoweredOn)
            {
                _displayPanel.DisplayText("Hello, this is a demo for PrintLine API.");
                _displayPanel.DisplayText("This is message is appearing in compatibility mode for each system.");
            }
        }

        public void PrintOutName(string name)
        {
            if (IsPoweredOn)
                _displayPanel.DisplayText(name);
        }
    }

    public class IPhone : IComputerSystem
    {
        public bool IsPoweredOn { get; private set; } = false;
        private Language _language;
        private IDisplayPanel _displayPanel;

        public IPhone(Language language, IDisplayPanel displayPanel)
        {
            _language = language;
            _displayPanel = displayPanel;
        }

        public void PowerOn() => IsPoweredOn = true;
        public void PowerOff() => IsPoweredOn = false;

        public void PrintOutMessage()
        {
            if (_language == Language.German && IsPoweredOn)
            {
                _displayPanel.DisplayText("Hallo, dies ist eine Demo für die PrintLine API.");
                _displayPanel.DisplayText("Diese Meldung erscheint im Kompatibilitätsmodus für jedes System.");
            }
            else if(IsPoweredOn)
            {
                _displayPanel.DisplayText("Hello, this is a demo for PrintLine API.");
                _displayPanel.DisplayText("This is message is appearing in compatibility mode for each system.");
            }
        }

        public void PrintOutName(string name)
        {
            if (IsPoweredOn)
                _displayPanel.DisplayText(name);
        }
    }

}
