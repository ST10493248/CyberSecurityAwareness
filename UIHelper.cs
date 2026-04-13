using System;
using System.Threading;

namespace CyberSecurityAwarenessBot
{
    public static class UIHelper
    {
        public static void SimulateTyping(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}

