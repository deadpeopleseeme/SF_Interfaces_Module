using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_Interfaces_Module
{
    internal class Logger : ILogger
    {
        public void DisplayCalcInfo(bool isEverythinOk)
        {
            string message;
            if (isEverythinOk)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                message = "\nвведено число\n";
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                message = "\nвведено не число, невозможно продолжить!\n";
            }
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

    public interface ILogger
    {
        void DisplayCalcInfo(bool isEverythinOk);
    }
}
