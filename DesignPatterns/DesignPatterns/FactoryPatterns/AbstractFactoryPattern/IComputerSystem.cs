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
        void PrintOutName(string name);
        void PrintOutMessage();
    }


    public class Commodore64 : IComputerSystem
    {
        private Language _language;
        public Commodore64(Language language)
        {
            _language = language;
        }

        public void PrintOutMessage()
        {
            if (_language == Language.German)
            {
                Console.WriteLine("Hallo, dies ist eine Demo für die PrintLine API.");
                Console.WriteLine("Diese Meldung erscheint im Kompatibilitätsmodus für jedes System.");
            }
            else
            {
                Console.WriteLine("Hello, this is a demo for PrintLine API.");
                Console.WriteLine("This is message is appearing in compatibility mode for each system.");
            }

            Thread.Sleep(1000);
            Console.Clear();
        }

        public void PrintOutName(string name)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(name);
            Thread.Sleep(1000);
        }
    }


    public class IBM : IComputerSystem
    {
        private Language _language;
        public IBM(Language language)
        {
            _language = language;
        }

        public void PrintOutMessage()
        {
            if (_language == Language.German)
            {
                Console.WriteLine("Hallo, dies ist eine Demo für die PrintLine API.");
                Console.WriteLine("Diese Meldung erscheint im Kompatibilitätsmodus für jedes System.");
            }
            else
            {
                Console.WriteLine("Hello, this is a demo for PrintLine API.");
                Console.WriteLine("This is message is appearing in compatibility mode for each system.");
            }

            Thread.Sleep(1000);
            Console.Clear();
        }

        public void PrintOutName(string name)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(name.ToUpper());
            Thread.Sleep(1000);
        }
    }


    public class OneHertzSystem : IComputerSystem
    {
        private Language _language;
        public OneHertzSystem(Language language)
        {
            _language = language;
        }

        public void PrintOutMessage()
        {
            if (_language == Language.German)
            {
                Console.WriteLine("Hallo, dies ist eine Demo für die PrintLine API.");
                Console.WriteLine("Diese Meldung erscheint im Kompatibilitätsmodus für jedes System.");
            }
            else
            {
                Console.WriteLine("Hello, this is a demo for PrintLine API.");
                Console.WriteLine("This is message is appearing in compatibility mode for each system.");
            }

            Thread.Sleep(1000);
            Console.Clear();
        }

        public void PrintOutName(string name)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"___{name.ToLower()}___");
            Thread.Sleep(1000);
        }
    }


    public class Android : IComputerSystem
    {
        private int _width, _height;
        private Language _language;
        public Android(Language language, int width, int height)
        {
            _language = language;
            _width = width;
            _height = height;
        }
        public void PrintOutMessage()
        {
            if (_language == Language.German)
            {
                Console.WriteLine("Hallo, dies ist eine Demo für die PrintLine API.");
                Console.WriteLine("Diese Meldung erscheint im Kompatibilitätsmodus für jedes System.");
            }
            else
            {
                Console.WriteLine("Hello, this is a demo for PrintLine API.");
                Console.WriteLine("This is message is appearing in compatibility mode for each system.");
            }

            Thread.Sleep(1000);
            Console.Clear();
        }


        public void PrintOutName(string name)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.WindowWidth = _width;
            Console.WindowHeight = _height;
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"___{name.ToLower()}___");
            Thread.Sleep(1000);
        }
    }


    public class IPhone : IComputerSystem
    {
        private int _width, _height;
        private Language _language;

        public IPhone(Language language, int width, int height)
        {
            _language = language;
            _width = width;
            _height = height;
        }

        public void PrintOutMessage()
        {
            if (_language == Language.German)
            {
                Console.WriteLine("Hallo, dies ist eine Demo für die PrintLine API.");
                Console.WriteLine("Diese Meldung erscheint im Kompatibilitätsmodus für jedes System.");
            }
            else
            {
                Console.WriteLine("Hello, this is a demo for PrintLine API.");
                Console.WriteLine("This is message is appearing in compatibility mode for each system.");
            }

            Thread.Sleep(1000);
            Console.Clear();
        }

        public void PrintOutName(string name)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.WindowWidth = _width;
            Console.WindowHeight = _height;
            Console.Beep();
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"___{name.ToLower()}___");
            Thread.Sleep(1000);
        }
    }

}
