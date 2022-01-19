using System;
using System.Threading;

namespace DesignPatterns.FactoryPatterns.FactoryMethodPattern
{
    //This uses inheritance -- implementing via subclass classes
    public abstract class ComputerSystem
    {
        protected Language _langauge;
        public abstract void PrintOutName(string name);

        public void PrintOutMessage()
        {
            if (_langauge == Language.German)
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
    }

    public class Commodore64 : ComputerSystem
    {
        public Commodore64(Language language)
        {
            base._langauge = language;
        }

        public override void PrintOutName(string name)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(name);
            Thread.Sleep(1000);
        }
    }

    public class IBM : ComputerSystem
    {
        public IBM(Language language)
        {
            base._langauge = language;
        }

        public override void PrintOutName(string name)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(name.ToUpper());
            Thread.Sleep(1000);
        }
    }

    public class OneHertzSystem : ComputerSystem
    {
        public OneHertzSystem(Language language)
        {
            base._langauge = language;
        }

        public override void PrintOutName(string name)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"___{name.ToLower()}___");
            Thread.Sleep(1000);
        }
    }


    public class Android : ComputerSystem
    {
        private int _width, _height;
        public Android(Language language, int width, int height)
        {
            base._langauge = language;
            _width = width;
            _height = height;
        }

        public override void PrintOutName(string name)
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

    public class IPhone : ComputerSystem
    {
        private int _width, _height;

        public IPhone(Language language,  int width, int height)
        {
            base._langauge = language;
            _width = width;
            _height = height;
        }

        public override void PrintOutName(string name)
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
