using System;
using System.Threading;

namespace DesignPatterns.FactoryPatterns.AbstractFactoryPattern
{
    public interface IDisplayPanel
    {
        void DisplayText(string text);
    }
    

    public class Commodore64DisplayPanel : IDisplayPanel
    {
        public void DisplayText(string text)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(text);
            Thread.Sleep(1000);
        }
    }

    public class IMBDisplayPanel : IDisplayPanel
    {
        public void DisplayText(string text)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(text.ToUpper());
            Thread.Sleep(1000);
        }
    }

    public class OneHertzSystemDisplayPanel : IDisplayPanel
    {      
        public void DisplayText(string text)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"___{text.ToLower()}___");
            Thread.Sleep(1000);
        }
    }

    public class IphoneDisplayPanel : IDisplayPanel
    {
        private int _width, _height;

        public IphoneDisplayPanel(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void DisplayText(string text)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.WindowWidth = _width;
            Console.WindowHeight = _height;
            Console.Beep();
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"****{text.ToLower()}****");
            Thread.Sleep(1000);
        }
    }

    public class AndroidDisplayPanel : IDisplayPanel
    {
        private int _width, _height;

        public AndroidDisplayPanel(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void DisplayText(string text)
        {
            Console.ResetColor();
            Console.Title = this.GetType().Name;
            Console.WindowWidth = _width;
            Console.WindowHeight = _height;
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"    {text.ToUpper()} ##");
            Thread.Sleep(1000);
        }
    }

}
