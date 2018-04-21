using System;

namespace CSharpExample
{
    class Program
    {
        public static void ColoredConsoleWrite(ConsoleColor color, string text)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = originalColor;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World!");
            Console.ResetColor();
            Console.WriteLine("Normal");
            ColoredConsoleWrite(ConsoleColor.Red, "Test");
        }
    }
}
