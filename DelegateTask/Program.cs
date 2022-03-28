using System;

namespace BarsGroup
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            KeyboardHandler keyboardHandler = new KeyboardHandler();
            keyboardHandler.OnKeyPressed += (sender, c) => Console.WriteLine(c);
            keyboardHandler.Run();
        }
    }
}