using System;
using System.Collections.Generic;
using System.Text;

namespace BestGame
{
    class ConsoleLogger:ILogger
    {
        public void Info(string message)
        {
            string info = "INFO: ";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(info);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(DateTime.Now + ": "  + message);
        }

        public void Winner(string message)
        {
            string info = "WINNER: ";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(info);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(DateTime.Now + ": " + message);
        }



        public void Error(string message)
        {
            string error = "ERROR: ";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(error);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(DateTime.Now + ": " + message);
        }
    }
}
