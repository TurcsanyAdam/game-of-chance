using System;
using System.Collections.Generic;
using System.Text;

namespace BestGame
{
    interface ILogger
    {
        void Info(string message);
        void Winner(string message);
        void Error(string message);
    }
}
